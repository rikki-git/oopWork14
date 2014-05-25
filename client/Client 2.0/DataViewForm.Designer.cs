﻿namespace Client_2._0 {
	partial class DataViewForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.dgItemList = new System.Windows.Forms.DataGridView();
            this.dgCurrentItem = new System.Windows.Forms.DataGridView();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItemList
            // 
            this.dgItemList.AllowUserToAddRows = false;
            this.dgItemList.AllowUserToDeleteRows = false;
            this.dgItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemList.Location = new System.Drawing.Point(12, 12);
            this.dgItemList.MultiSelect = false;
            this.dgItemList.Name = "dgItemList";
            this.dgItemList.ReadOnly = true;
            this.dgItemList.RowHeadersVisible = false;
            this.dgItemList.Size = new System.Drawing.Size(535, 207);
            this.dgItemList.TabIndex = 0;
            this.dgItemList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemList_RowClick);
            // 
            // dgCurrentItem
            // 
            this.dgCurrentItem.AllowUserToAddRows = false;
            this.dgCurrentItem.AllowUserToDeleteRows = false;
            this.dgCurrentItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCurrentItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgCurrentItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrentItem.Location = new System.Drawing.Point(12, 225);
            this.dgCurrentItem.Name = "dgCurrentItem";
            this.dgCurrentItem.RowHeadersVisible = false;
            this.dgCurrentItem.Size = new System.Drawing.Size(535, 48);
            this.dgCurrentItem.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 279);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(93, 279);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Изменить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(472, 279);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(75, 23);
            this.bReturn.TabIndex = 5;
            this.bReturn.Text = "Назад";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 310);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgCurrentItem);
            this.Controls.Add(this.dgItemList);
            this.Name = "DataViewForm";
            this.ShowIcon = false;
            this.Text = "Название таблицы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataViewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentItem)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgItemList;
		private System.Windows.Forms.DataGridView dgCurrentItem;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReturn;
	}
}