using System;
using System.IO;
using System.Drawing;
using System.Data.Common;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ADoors
{
    public static class SQLClass
    {
        public static MySqlConnection conn;

        public static void OpenConnection()
        {
            conn = new MySqlConnection
            {
                ConnectionString =
                "Server = VH287.spaceweb.ru;" +
                "Database = beavisabra_adoor;" +
                "port = 3306;" +
                "User Id = beavisabra_adoor;" +
                "password = Beavis1989"
            };
            conn.Open();
        }

        public static void CloseConnection()
        {
            conn.Close();
            conn.Dispose();
        }

        public static void UpdateImg(String Text, String address)
        {
            FileStream pgFileStream = new FileStream(address, FileMode.Open, FileAccess.Read);
            BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream));
            MySqlCommand command = new MySqlCommand(Text, conn);

            byte[] ImgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));

            MySqlParameter param = command.CreateParameter();
            param.ParameterName = "?Image";
            param.MySqlDbType = MySqlDbType.Blob;
            param.Value = ImgByteA;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            pgReader.Dispose();
            command.Dispose();
            pgFileStream.Dispose();
        }

        public static long Update(string Text, List<MySqlParameter> sqlParams = null)
        {
            long result = 0;
            
            // Создать команду
            MySqlCommand command = new MySqlCommand(Text, conn);

            // Добавить параметры, если есть
            if (sqlParams != null)
                sqlParams.ForEach((MySqlParameter _sqlparam) => {
                    command.Parameters.Add(_sqlparam);
                });


            // Выполнить команду
            try
            {
                DbDataReader reader = command.ExecuteReader();
                result = command.LastInsertedId;
                reader.Close();
            }
            catch (Exception e) {
                string s = e.Message;
            }

            command.Dispose();
            return result;
        }
    
        public static List<string> Select(string Text, List<MySqlParameter> sqlParams = null)
        {
            // Результат
            List<string> results = new List<string>();

            // Создать команду
            MySqlCommand command = new MySqlCommand(Text, conn);

            // Добавить параметры, если есть
            if (sqlParams != null)
                sqlParams.ForEach((MySqlParameter _sqlparam) => {
                    command.Parameters.Add(_sqlparam);
                });

            // Выполнить команду
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetValue(i).ToString());
            }

            reader.Close();
            command.Dispose();

            return results;
        }

        public static List<Image> SelectImages(string text)
        {
            List<Image> img = new List<Image>();

            MySqlCommand command = new MySqlCommand(text, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    byte[] data = (byte[])reader.GetValue(0);
                    try
                    {
                        MemoryStream ms = new MemoryStream(data, 0, data.Length);
                        ms.Write(data, 0, data.Length);
                        img.Add(Image.FromStream(ms, true));
                    }
                    catch
                    {
                        img.Add(null);
                    }
                }
            }

            reader.Close();
            command.Dispose();

            return img;
        }
    }
}
