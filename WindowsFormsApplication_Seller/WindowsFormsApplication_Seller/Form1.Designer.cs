namespace WindowsFormsApplication_Seller
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Meny = new System.Windows.Forms.ComboBox();
            this.listBox_Table = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Meny
            // 
            this.comboBox_Meny.FormattingEnabled = true;
            this.comboBox_Meny.Items.AddRange(new object[] {
            "Продавцы",
            "Покупатели ",
            "Продажи"});
            this.comboBox_Meny.Location = new System.Drawing.Point(115, 25);
            this.comboBox_Meny.Name = "comboBox_Meny";
            this.comboBox_Meny.Size = new System.Drawing.Size(381, 21);
            this.comboBox_Meny.TabIndex = 1;
            // 
            // listBox_Table
            // 
            this.listBox_Table.FormattingEnabled = true;
            this.listBox_Table.Location = new System.Drawing.Point(12, 154);
            this.listBox_Table.Name = "listBox_Table";
            this.listBox_Table.Size = new System.Drawing.Size(484, 95);
            this.listBox_Table.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 261);
            this.Controls.Add(this.listBox_Table);
            this.Controls.Add(this.comboBox_Meny);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Meny;
        private System.Windows.Forms.ListBox listBox_Table;
    }
}

