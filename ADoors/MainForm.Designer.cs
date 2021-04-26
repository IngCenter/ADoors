﻿
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
            this.label6 = new System.Windows.Forms.Label();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).BeginInit();
            this.DoorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Peru;
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
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(267, 266);
            this.OptionsPanel.TabIndex = 0;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComputeButton.Location = new System.Drawing.Point(0, 238);
            this.ComputeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(267, 28);
            this.ComputeButton.TabIndex = 12;
            this.ComputeButton.Text = "Рассчитать!";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // DoorCountChoice
            // 
            this.DoorCountChoice.Location = new System.Drawing.Point(120, 193);
            this.DoorCountChoice.Margin = new System.Windows.Forms.Padding(4);
            this.DoorCountChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoorCountChoice.Name = "DoorCountChoice";
            this.DoorCountChoice.Size = new System.Drawing.Size(143, 22);
            this.DoorCountChoice.TabIndex = 11;
            this.DoorCountChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во дверей";
            // 
            // PlatbandChoice
            // 
            this.PlatbandChoice.AutoSize = true;
            this.PlatbandChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlatbandChoice.Location = new System.Drawing.Point(4, 166);
            this.PlatbandChoice.Margin = new System.Windows.Forms.Padding(4);
            this.PlatbandChoice.Name = "PlatbandChoice";
            this.PlatbandChoice.Size = new System.Drawing.Size(95, 21);
            this.PlatbandChoice.TabIndex = 9;
            this.PlatbandChoice.Text = "Наличник";
            this.PlatbandChoice.UseVisualStyleBackColor = true;
            // 
            // DoorHandleChoice
            // 
            this.DoorHandleChoice.AutoSize = true;
            this.DoorHandleChoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoorHandleChoice.Location = new System.Drawing.Point(4, 138);
            this.DoorHandleChoice.Margin = new System.Windows.Forms.Padding(4);
            this.DoorHandleChoice.Name = "DoorHandleChoice";
            this.DoorHandleChoice.Size = new System.Drawing.Size(93, 21);
            this.DoorHandleChoice.TabIndex = 8;
            this.DoorHandleChoice.Text = "Ручка      ";
            this.DoorHandleChoice.UseVisualStyleBackColor = true;
            // 
            // WidthChoice
            // 
            this.WidthChoice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthChoice.Location = new System.Drawing.Point(75, 106);
            this.WidthChoice.Margin = new System.Windows.Forms.Padding(4);
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
            this.WidthChoice.Size = new System.Drawing.Size(188, 22);
            this.WidthChoice.TabIndex = 7;
            this.WidthChoice.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
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
            "Остеклённый (Матовое стекло) ",
            "Частично остеклённый (Искажённое стекло)",
            "Остеклённый (Искажённое стекло) "});
            this.TypeChoice.Location = new System.Drawing.Point(73, 73);
            this.TypeChoice.Margin = new System.Windows.Forms.Padding(4);
            this.TypeChoice.Name = "TypeChoice";
            this.TypeChoice.Size = new System.Drawing.Size(188, 24);
            this.TypeChoice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // ColorChoice
            // 
            this.ColorChoice.FormattingEnabled = true;
            this.ColorChoice.Items.AddRange(new object[] {
            "Эмаль",
            "Бреннерский орех",
            "Венге"});
            this.ColorChoice.Location = new System.Drawing.Point(73, 42);
            this.ColorChoice.Margin = new System.Windows.Forms.Padding(4);
            this.ColorChoice.Name = "ColorChoice";
            this.ColorChoice.Size = new System.Drawing.Size(188, 24);
            this.ColorChoice.TabIndex = 3;
            this.ColorChoice.Text = "Эмаль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // ModelChoice
            // 
            this.ModelChoice.FormattingEnabled = true;
            this.ModelChoice.Items.AddRange(new object[] {
            "Леонардо",
            "Трио",
            "Черчилль",
            "Рузвельт",
            "Маргарет"});
            this.ModelChoice.Location = new System.Drawing.Point(73, 7);
            this.ModelChoice.Margin = new System.Windows.Forms.Padding(4);
            this.ModelChoice.Name = "ModelChoice";
            this.ModelChoice.Size = new System.Drawing.Size(188, 24);
            this.ModelChoice.TabIndex = 0;
            this.ModelChoice.Text = "Леонардо";
            // 
            // DoorPanel
            // 
            this.DoorPanel.Controls.Add(this.label6);
            this.DoorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoorPanel.Location = new System.Drawing.Point(267, 0);
            this.DoorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DoorPanel.Name = "DoorPanel";
            this.DoorPanel.Size = new System.Drawing.Size(346, 266);
            this.DoorPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 266);
            this.Controls.Add(this.DoorPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Калькулятор стоимости двери";
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorCountChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChoice)).EndInit();
            this.DoorPanel.ResumeLayout(false);
            this.DoorPanel.PerformLayout();
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
        private System.Windows.Forms.Label label6;
    }
}

