namespace ADoors
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.DoorCountChoice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PlatbandChoice = new System.Windows.Forms.CheckBox();
            this.DoorHandleChoice = new System.Windows.Forms.CheckBox();
            this.WidthChoice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelChoice = new System.Windows.Forms.ComboBox();
            this.DoorPanel = new System.Windows.Forms.Panel();
            this.DoorPB = new System.Windows.Forms.PictureBox();
            this.CostInfoPanel = new System.Windows.Forms.Panel();
            this.Textpricelabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ShippingPanel = new System.Windows.Forms.Panel();
            this.floorNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ShippingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ElevatorCB = new System.Windows.Forms.CheckBox();
            this.ShippingCB = new System.Windows.Forms.CheckBox();
            this.ComplectationCB = new System.Windows.Forms.CheckBox();
            this.UlskRB = new System.Windows.Forms.RadioButton();
            this.NonUlskRB = new System.Windows.Forms.RadioButton();
            this.DistanceTB = new System.Windows.Forms.TextBox();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).BeginInit();
            this.DoorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).BeginInit();
            this.CostInfoPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.ShippingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Peru;
            this.OptionsPanel.Controls.Add(this.pictureBox1);
            this.OptionsPanel.Controls.Add(this.ComputeButton);
            this.OptionsPanel.Controls.Add(this.DoorCountChoice);
            this.OptionsPanel.Controls.Add(this.label5);
            this.OptionsPanel.Controls.Add(this.PlatbandChoice);
            this.OptionsPanel.Controls.Add(this.DoorHandleChoice);
            this.OptionsPanel.Controls.Add(this.WidthChoice);
            this.OptionsPanel.Controls.Add(this.label4);
            this.OptionsPanel.Controls.Add(this.TypeChoice);
            this.OptionsPanel.Controls.Add(this.label3);
            this.OptionsPanel.Controls.Add(this.ColorChoice);
            this.OptionsPanel.Controls.Add(this.label2);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.ModelChoice);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.OptionsPanel.Size = new System.Drawing.Size(434, 393);
            this.OptionsPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(406, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 81);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComputeButton.Location = new System.Drawing.Point(0, 347);
            this.ComputeButton.Margin = new System.Windows.Forms.Padding(6);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(434, 46);
            this.ComputeButton.TabIndex = 12;
            this.ComputeButton.Text = "Рассчитать!";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // DoorCountChoice
            // 
            this.DoorCountChoice.Location = new System.Drawing.Point(195, 314);
            this.DoorCountChoice.Margin = new System.Windows.Forms.Padding(6);
            this.DoorCountChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoorCountChoice.Name = "DoorCountChoice";
            this.DoorCountChoice.Size = new System.Drawing.Size(232, 32);
            this.DoorCountChoice.TabIndex = 11;
            this.DoorCountChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoorCountChoice.ValueChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во дверей";
            // 
            // PlatbandChoice
            // 
            this.PlatbandChoice.AutoSize = true;
            this.PlatbandChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlatbandChoice.Location = new System.Drawing.Point(6, 270);
            this.PlatbandChoice.Margin = new System.Windows.Forms.Padding(6);
            this.PlatbandChoice.Name = "PlatbandChoice";
            this.PlatbandChoice.Size = new System.Drawing.Size(134, 30);
            this.PlatbandChoice.TabIndex = 9;
            this.PlatbandChoice.Text = "Наличник";
            this.PlatbandChoice.UseVisualStyleBackColor = true;
            this.PlatbandChoice.CheckStateChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // DoorHandleChoice
            // 
            this.DoorHandleChoice.AutoSize = true;
            this.DoorHandleChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoorHandleChoice.Location = new System.Drawing.Point(6, 224);
            this.DoorHandleChoice.Margin = new System.Windows.Forms.Padding(6);
            this.DoorHandleChoice.Name = "DoorHandleChoice";
            this.DoorHandleChoice.Size = new System.Drawing.Size(131, 30);
            this.DoorHandleChoice.TabIndex = 8;
            this.DoorHandleChoice.Text = "Ручка      ";
            this.DoorHandleChoice.UseVisualStyleBackColor = true;
            this.DoorHandleChoice.CheckStateChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // WidthChoice
            // 
            this.WidthChoice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthChoice.Location = new System.Drawing.Point(122, 172);
            this.WidthChoice.Margin = new System.Windows.Forms.Padding(6);
            this.WidthChoice.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.WidthChoice.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.WidthChoice.Name = "WidthChoice";
            this.WidthChoice.Size = new System.Drawing.Size(306, 32);
            this.WidthChoice.TabIndex = 7;
            this.WidthChoice.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.WidthChoice.ValueChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ширина";
            // 
            // TypeChoice
            // 
            this.TypeChoice.FormattingEnabled = true;
            this.TypeChoice.Items.AddRange(new object[] {
            "Без стеклянных элементов",
            "Частично остеклённый",
            "Остеклённый",
            "Частично остеклённый (Матовое стекло)",
            "Остеклённый (Матовое стекло)",
            "Частично остеклённый (Искажённое стекло)",
            "Остеклённый (Искажённое стекло)"});
            this.TypeChoice.Location = new System.Drawing.Point(119, 119);
            this.TypeChoice.Margin = new System.Windows.Forms.Padding(6);
            this.TypeChoice.Name = "TypeChoice";
            this.TypeChoice.Size = new System.Drawing.Size(303, 34);
            this.TypeChoice.TabIndex = 5;
            this.TypeChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // ColorChoice
            // 
            this.ColorChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorChoice.FormattingEnabled = true;
            this.ColorChoice.Items.AddRange(new object[] {
            "Эмаль",
            "Бреннерский орех",
            "Венге"});
            this.ColorChoice.Location = new System.Drawing.Point(119, 68);
            this.ColorChoice.Margin = new System.Windows.Forms.Padding(6);
            this.ColorChoice.Name = "ColorChoice";
            this.ColorChoice.Size = new System.Drawing.Size(303, 34);
            this.ColorChoice.TabIndex = 3;
            this.ColorChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // ModelChoice
            // 
            this.ModelChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelChoice.FormattingEnabled = true;
            this.ModelChoice.Items.AddRange(new object[] {
            "Леонардо",
            "Трио",
            "Черчилль",
            "Рузвельт",
            "Маргарет"});
            this.ModelChoice.Location = new System.Drawing.Point(119, 11);
            this.ModelChoice.Margin = new System.Windows.Forms.Padding(6);
            this.ModelChoice.Name = "ModelChoice";
            this.ModelChoice.Size = new System.Drawing.Size(303, 34);
            this.ModelChoice.TabIndex = 0;
            this.ModelChoice.SelectedIndexChanged += new System.EventHandler(this.ModelChoice_SelectedIndexChanged);
            // 
            // DoorPanel
            // 
            this.DoorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DoorPanel.Controls.Add(this.ShippingPanel);
            this.DoorPanel.Controls.Add(this.DoorPB);
            this.DoorPanel.Controls.Add(this.CostInfoPanel);
            this.DoorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoorPanel.Location = new System.Drawing.Point(434, 0);
            this.DoorPanel.Margin = new System.Windows.Forms.Padding(6);
            this.DoorPanel.Name = "DoorPanel";
            this.DoorPanel.Size = new System.Drawing.Size(562, 393);
            this.DoorPanel.TabIndex = 1;
            // 
            // DoorPB
            // 
            this.DoorPB.Dock = System.Windows.Forms.DockStyle.Right;
            this.DoorPB.Image = global::ADoors.Properties.Resources.door_cherchill;
            this.DoorPB.Location = new System.Drawing.Point(0, 0);
            this.DoorPB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DoorPB.Name = "DoorPB";
            this.DoorPB.Size = new System.Drawing.Size(562, 352);
            this.DoorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoorPB.TabIndex = 2;
            this.DoorPB.TabStop = false;
            // 
            // CostInfoPanel
            // 
            this.CostInfoPanel.Controls.Add(this.Textpricelabel);
            this.CostInfoPanel.Controls.Add(this.Pricelabel);
            this.CostInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CostInfoPanel.Location = new System.Drawing.Point(0, 352);
            this.CostInfoPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CostInfoPanel.Name = "CostInfoPanel";
            this.CostInfoPanel.Size = new System.Drawing.Size(562, 41);
            this.CostInfoPanel.TabIndex = 3;
            // 
            // Textpricelabel
            // 
            this.Textpricelabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Textpricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textpricelabel.Location = new System.Drawing.Point(0, 0);
            this.Textpricelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Textpricelabel.Name = "Textpricelabel";
            this.Textpricelabel.Size = new System.Drawing.Size(214, 41);
            this.Textpricelabel.TabIndex = 1;
            this.Textpricelabel.Text = "Итоговая цена:";
            this.Textpricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pricelabel
            // 
            this.Pricelabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pricelabel.Location = new System.Drawing.Point(222, 0);
            this.Pricelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(340, 41);
            this.Pricelabel.TabIndex = 0;
            this.Pricelabel.Text = "нажмите \"Рассчитать!\"";
            this.Pricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginPanel
            // 
            this.LoginPanel.ColumnCount = 5;
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginPanel.Controls.Add(this.PasswordTB, 3, 0);
            this.LoginPanel.Controls.Add(this.PasswordLbl, 2, 0);
            this.LoginPanel.Controls.Add(this.LoginLbl, 0, 0);
            this.LoginPanel.Controls.Add(this.LoginTB, 1, 0);
            this.LoginPanel.Controls.Add(this.LoginBtn, 4, 0);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanel.Location = new System.Drawing.Point(0, 393);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(1);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.RowCount = 1;
            this.LoginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginPanel.Size = new System.Drawing.Size(996, 39);
            this.LoginPanel.TabIndex = 2;
            this.LoginPanel.Visible = false;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTB.Location = new System.Drawing.Point(600, 3);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(193, 32);
            this.PasswordTB.TabIndex = 3;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLbl.Location = new System.Drawing.Point(401, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(193, 39);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Пароль";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginLbl
            // 
            this.LoginLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLbl.Location = new System.Drawing.Point(3, 0);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(193, 39);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Логин";
            this.LoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginTB
            // 
            this.LoginTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTB.Location = new System.Drawing.Point(202, 3);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(193, 32);
            this.LoginTB.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBtn.Location = new System.Drawing.Point(799, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(194, 33);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ShippingPanel
            // 
            this.ShippingPanel.BackColor = System.Drawing.Color.Peru;
            this.ShippingPanel.Controls.Add(this.DistanceTB);
            this.ShippingPanel.Controls.Add(this.NonUlskRB);
            this.ShippingPanel.Controls.Add(this.UlskRB);
            this.ShippingPanel.Controls.Add(this.ComplectationCB);
            this.ShippingPanel.Controls.Add(this.ShippingCB);
            this.ShippingPanel.Controls.Add(this.ElevatorCB);
            this.ShippingPanel.Controls.Add(this.floorNUD);
            this.ShippingPanel.Controls.Add(this.label9);
            this.ShippingPanel.Controls.Add(this.label10);
            this.ShippingPanel.Controls.Add(this.ShippingTypeComboBox);
            this.ShippingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShippingPanel.Location = new System.Drawing.Point(0, 0);
            this.ShippingPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ShippingPanel.Name = "ShippingPanel";
            this.ShippingPanel.Size = new System.Drawing.Size(329, 301);
            this.ShippingPanel.TabIndex = 4;
            // 
            // floorNUD
            // 
            this.floorNUD.Location = new System.Drawing.Point(69, 244);
            this.floorNUD.Margin = new System.Windows.Forms.Padding(5);
            this.floorNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.floorNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorNUD.Name = "floorNUD";
            this.floorNUD.Size = new System.Drawing.Size(91, 26);
            this.floorNUD.TabIndex = 7;
            this.floorNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Этаж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Способ доставки";
            // 
            // ShippingTypeComboBox
            // 
            this.ShippingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShippingTypeComboBox.FormattingEnabled = true;
            this.ShippingTypeComboBox.Items.AddRange(new object[] {
            "До квартиры",
            "До подъезда"});
            this.ShippingTypeComboBox.Location = new System.Drawing.Point(5, 194);
            this.ShippingTypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ShippingTypeComboBox.Name = "ShippingTypeComboBox";
            this.ShippingTypeComboBox.Size = new System.Drawing.Size(315, 28);
            this.ShippingTypeComboBox.TabIndex = 0;
            // 
            // ElevatorCB
            // 
            this.ElevatorCB.AutoSize = true;
            this.ElevatorCB.Location = new System.Drawing.Point(241, 244);
            this.ElevatorCB.Name = "ElevatorCB";
            this.ElevatorCB.Size = new System.Drawing.Size(79, 24);
            this.ElevatorCB.TabIndex = 8;
            this.ElevatorCB.Text = "Лифт";
            this.ElevatorCB.UseVisualStyleBackColor = true;
            // 
            // ShippingCB
            // 
            this.ShippingCB.AutoSize = true;
            this.ShippingCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ShippingCB.Location = new System.Drawing.Point(8, 64);
            this.ShippingCB.Name = "ShippingCB";
            this.ShippingCB.Size = new System.Drawing.Size(132, 29);
            this.ShippingCB.TabIndex = 9;
            this.ShippingCB.Text = "Доставка";
            this.ShippingCB.UseVisualStyleBackColor = true;
            // 
            // ComplectationCB
            // 
            this.ComplectationCB.AutoSize = true;
            this.ComplectationCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComplectationCB.Location = new System.Drawing.Point(9, 9);
            this.ComplectationCB.Name = "ComplectationCB";
            this.ComplectationCB.Size = new System.Drawing.Size(106, 29);
            this.ComplectationCB.TabIndex = 10;
            this.ComplectationCB.Text = "Сборка";
            this.ComplectationCB.UseVisualStyleBackColor = true;
            // 
            // UlskRB
            // 
            this.UlskRB.AutoSize = true;
            this.UlskRB.Location = new System.Drawing.Point(8, 95);
            this.UlskRB.Name = "UlskRB";
            this.UlskRB.Size = new System.Drawing.Size(119, 24);
            this.UlskRB.TabIndex = 11;
            this.UlskRB.TabStop = true;
            this.UlskRB.Text = "Ульяновск";
            this.UlskRB.UseVisualStyleBackColor = true;
            // 
            // NonUlskRB
            // 
            this.NonUlskRB.AutoSize = true;
            this.NonUlskRB.Location = new System.Drawing.Point(8, 125);
            this.NonUlskRB.Name = "NonUlskRB";
            this.NonUlskRB.Size = new System.Drawing.Size(265, 24);
            this.NonUlskRB.TabIndex = 12;
            this.NonUlskRB.TabStop = true;
            this.NonUlskRB.Text = "Другой город в                 км";
            this.NonUlskRB.UseVisualStyleBackColor = true;
            // 
            // DistanceTB
            // 
            this.DistanceTB.Location = new System.Drawing.Point(167, 123);
            this.DistanceTB.Name = "DistanceTB";
            this.DistanceTB.Size = new System.Drawing.Size(66, 26);
            this.DistanceTB.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 432);
            this.Controls.Add(this.DoorPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Калькулятор стоимости двери";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).EndInit();
            this.DoorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoorPB)).EndInit();
            this.CostInfoPanel.ResumeLayout(false);
            this.ShippingPanel.ResumeLayout(false);
            this.ShippingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModelChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PlatbandChoice;
        private System.Windows.Forms.CheckBox DoorHandleChoice;
        private System.Windows.Forms.NumericUpDown WidthChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorChoice;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.NumericUpDown DoorCountChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel DoorPanel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label Textpricelabel;
        private System.Windows.Forms.PictureBox DoorPB;
        private System.Windows.Forms.Panel CostInfoPanel;
        private System.Windows.Forms.TableLayoutPanel LoginPanel;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel ShippingPanel;
        private System.Windows.Forms.CheckBox ElevatorCB;
        private System.Windows.Forms.NumericUpDown floorNUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ShippingTypeComboBox;
        private System.Windows.Forms.TextBox DistanceTB;
        private System.Windows.Forms.RadioButton NonUlskRB;
        private System.Windows.Forms.RadioButton UlskRB;
        private System.Windows.Forms.CheckBox ComplectationCB;
        private System.Windows.Forms.CheckBox ShippingCB;
    }
}

