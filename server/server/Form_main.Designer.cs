﻿namespace server
{
    partial class Form_main
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDiaLog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbTimerInterval = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(535, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Запуск сервера";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(653, 234);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 262);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(133, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "http://localhost:8081/";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Хост";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 291);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Путь к БД";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(80, 288);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "db\\oopDB.mdf";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(154, 324);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Настроить e-mail";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(18, 324);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(130, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "Указать путь к БД";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// openFileDiaLog1
			// 
			this.openFileDiaLog1.Title = "Выберите файл базы данных";
			this.openFileDiaLog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// tbTimerInterval
			// 
			this.tbTimerInterval.Location = new System.Drawing.Point(314, 326);
			this.tbTimerInterval.Name = "tbTimerInterval";
			this.tbTimerInterval.Size = new System.Drawing.Size(215, 20);
			this.tbTimerInterval.TabIndex = 8;
			this.tbTimerInterval.Text = "Введите интервал проверки почты";
			this.tbTimerInterval.Enter += new System.EventHandler(this.tbTimerInterval_Enter);
			this.tbTimerInterval.Leave += new System.EventHandler(this.tbTimerInterval_Leave);
			// 
			// Form_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 369);
			this.Controls.Add(this.tbTimerInterval);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form_main";
			this.Text = "Server";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDiaLog1;
		private System.Windows.Forms.TextBox tbTimerInterval;
    }
}

