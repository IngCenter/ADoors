using System;

namespace ADoors
{

    /// <summary>
    /// Нумерация модели понятными словами, 
    /// т.е. вместо 0 можно писать Трио.
    /// </summary>
    public enum ModelId
    {
        Трио,
        Черчилль,
        Рузвельт,
        Маргарет,
        Леонардо
    }

    /// <summary>
    /// Нумерация цветов
    /// </summary>
    public enum ColorId
    {
        Бреннерский_орех,
        Венге,
        Эмаль
    }

    public class Door
    {

        /// <summary>
        /// Название модели
        /// </summary>
        public int Model { get; set; }

        /// <summary>
        /// Цвет
        /// </summary>
        public int Color { get; set; }

        /// <summary>
        /// Тип полотна (остеклённый, глухой...)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Ширина полотна, в миллиметрах
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Есть ли дверная ручка?
        /// </summary>
        public bool HasDoorhandle { get; set; }

        /// <summary>
        /// Есть ли наличник?
        /// </summary>
        public bool HasPlatband { get; set; }

        public Door(
            ModelId _model, ColorId _color,
            string _type, int _width,
            bool _doorhandle, bool _platband
        )
        {
            Model = (int)_model;
            Color = (int)_color;
            Type = (_type != null) ? _type.Trim() : "";
            Width = _width;
            HasDoorhandle = _doorhandle;
            HasPlatband = _platband;
        }

        /// <summary>
        /// Рассчитать стоимость
        /// </summary>
        /// <returns></returns>
        public int ComputeCost(int _count = 1)
        {
            return 0;
        }
    }
}
