namespace refManager
{
    partial class AddRecipeItems
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbItemUnit = new System.Windows.Forms.ComboBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.cbItemAmount = new System.Windows.Forms.TextBox();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRecipeName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbItemUnit);
            this.groupBox2.Controls.Add(this.cbItemType);
            this.groupBox2.Controls.Add(this.dgvItems);
            this.groupBox2.Controls.Add(this.btnItemAdd);
            this.groupBox2.Controls.Add(this.cbItemAmount);
            this.groupBox2.Controls.Add(this.cbItemName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 309);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "재료구성";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "단위";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "용량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "품목종류";
            // 
            // cbItemUnit
            // 
            this.cbItemUnit.FormattingEnabled = true;
            this.cbItemUnit.Location = new System.Drawing.Point(283, 67);
            this.cbItemUnit.Name = "cbItemUnit";
            this.cbItemUnit.Size = new System.Drawing.Size(60, 20);
            this.cbItemUnit.TabIndex = 14;
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(17, 67);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(95, 20);
            this.cbItemType.TabIndex = 13;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(17, 94);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.Size = new System.Drawing.Size(407, 188);
            this.dgvItems.TabIndex = 12;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(349, 67);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(75, 21);
            this.btnItemAdd.TabIndex = 10;
            this.btnItemAdd.Text = "추가";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            // 
            // cbItemAmount
            // 
            this.cbItemAmount.Location = new System.Drawing.Point(208, 67);
            this.cbItemAmount.Name = "cbItemAmount";
            this.cbItemAmount.Size = new System.Drawing.Size(69, 21);
            this.cbItemAmount.TabIndex = 9;
            // 
            // cbItemName
            // 
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(118, 67);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(84, 20);
            this.cbItemName.TabIndex = 8;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(15, 29);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(53, 12);
            this.lblRecipeName.TabIndex = 19;
            this.lblRecipeName.Text = "레시피명";
            // 
            // AddRecipeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 343);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddRecipeItems";
            this.Text = "AddRecipeItems";
            this.Load += new System.EventHandler(this.AddRecipeItems_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbItemUnit;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.TextBox cbItemAmount;
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Label lblRecipeName;
    }
}