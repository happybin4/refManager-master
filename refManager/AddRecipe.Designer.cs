namespace refManager
{
    partial class AddRecipe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddRItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRItem);
            this.groupBox1.Controls.Add(this.txtRecipe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRecName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 415);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "레시피 추가";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(78, 75);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecipe.Size = new System.Drawing.Size(367, 300);
            this.txtRecipe.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "레시피";
            // 
            // txtRecName
            // 
            this.txtRecName.Location = new System.Drawing.Point(78, 40);
            this.txtRecName.Name = "txtRecName";
            this.txtRecName.Size = new System.Drawing.Size(100, 21);
            this.txtRecName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "레시피명";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "레시피 추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddRItem
            // 
            this.btnAddRItem.Location = new System.Drawing.Point(336, 381);
            this.btnAddRItem.Name = "btnAddRItem";
            this.btnAddRItem.Size = new System.Drawing.Size(109, 23);
            this.btnAddRItem.TabIndex = 19;
            this.btnAddRItem.Text = "필요한 재료 추가";
            this.btnAddRItem.UseVisualStyleBackColor = true;
            this.btnAddRItem.Click += new System.EventHandler(this.btnAddRItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRecipe";
            this.Text = " AddRecipe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRItem;
        private System.Windows.Forms.Button button3;
    }
}