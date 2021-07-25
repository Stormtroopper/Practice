namespace BANK_MANAGEMENT_SYSTEM
{
    partial class Loansgiven
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DG3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.LotypeTextBox = new System.Windows.Forms.TextBox();
            this.AddText = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LATextBox = new System.Windows.Forms.TextBox();
            this.SearchTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG3)).BeginInit();
            this.SuspendLayout();
            // 
            // DG3
            // 
            this.DG3.BackgroundColor = System.Drawing.Color.White;
            this.DG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG3.Location = new System.Drawing.Point(70, 84);
            this.DG3.Name = "DG3";
            this.DG3.Size = new System.Drawing.Size(493, 150);
            this.DG3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "LO_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "LO_TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "AMOUNT";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(117, 316);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(152, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(117, 349);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(152, 20);
            this.AmountTextBox.TabIndex = 5;
            // 
            // LotypeTextBox
            // 
            this.LotypeTextBox.Location = new System.Drawing.Point(424, 316);
            this.LotypeTextBox.Name = "LotypeTextBox";
            this.LotypeTextBox.Size = new System.Drawing.Size(139, 20);
            this.LotypeTextBox.TabIndex = 6;
            // 
            // AddText
            // 
            this.AddText.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddText.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddText.Image = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.add;
            this.AddText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddText.Location = new System.Drawing.Point(44, 256);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(121, 23);
            this.AddText.TabIndex = 7;
            this.AddText.Text = "ADD";
            this.AddText.UseVisualStyleBackColor = false;
            this.AddText.Click += new System.EventHandler(this.AddText_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Image = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.update;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(189, 256);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(121, 23);
            this.Update.TabIndex = 8;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Image = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(336, 256);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Image = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.clear;
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.Location = new System.Drawing.Point(482, 256);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "LA";
            // 
            // LATextBox
            // 
            this.LATextBox.Location = new System.Drawing.Point(252, 20);
            this.LATextBox.Name = "LATextBox";
            this.LATextBox.Size = new System.Drawing.Size(187, 20);
            this.LATextBox.TabIndex = 12;
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTab.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTab.Location = new System.Drawing.Point(279, 46);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Size = new System.Drawing.Size(128, 23);
            this.SearchTab.TabIndex = 13;
            this.SearchTab.Text = "SEARCH";
            this.SearchTab.UseVisualStyleBackColor = false;
            this.SearchTab.Click += new System.EventHandler(this.SearchTab_Click);
            // 
            // Loansgiven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.aboutapp;
            this.Controls.Add(this.SearchTab);
            this.Controls.Add(this.LATextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.LotypeTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG3);
            this.Name = "Loansgiven";
            this.Size = new System.Drawing.Size(642, 425);
            this.Load += new System.EventHandler(this.Loansgiven_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox LotypeTextBox;
        private System.Windows.Forms.Button AddText;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LATextBox;
        private System.Windows.Forms.Button SearchTab;
    }
}
