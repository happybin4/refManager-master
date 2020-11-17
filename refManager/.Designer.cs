namespace refManager
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbRef1 = new System.Windows.Forms.RadioButton();
            this.rbRef2 = new System.Windows.Forms.RadioButton();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItmeType = new System.Windows.Forms.TextBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbAmountType = new System.Windows.Forms.ComboBox();
            this.dtpDday = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.냉장고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.냉장고추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목추가ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.품목수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.요리하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장바구니ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장바구니관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장바구니에추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRefName = new System.Windows.Forms.ComboBox();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "<품목추가>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "* 품목명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "* 품목종류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "* 보관장소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "* 갯수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "용량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "* 유통기한";
            // 
            // rbRef1
            // 
            this.rbRef1.AutoSize = true;
            this.rbRef1.Location = new System.Drawing.Point(159, 248);
            this.rbRef1.Name = "rbRef1";
            this.rbRef1.Size = new System.Drawing.Size(47, 16);
            this.rbRef1.TabIndex = 4;
            this.rbRef1.TabStop = true;
            this.rbRef1.Text = "냉장";
            this.rbRef1.UseVisualStyleBackColor = true;
            // 
            // rbRef2
            // 
            this.rbRef2.AutoSize = true;
            this.rbRef2.Location = new System.Drawing.Point(216, 248);
            this.rbRef2.Name = "rbRef2";
            this.rbRef2.Size = new System.Drawing.Size(47, 16);
            this.rbRef2.TabIndex = 5;
            this.rbRef2.TabStop = true;
            this.rbRef2.Text = "냉동";
            this.rbRef2.UseVisualStyleBackColor = true;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(159, 189);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(101, 21);
            this.txtItemName.TabIndex = 1;
            // 
            // txtItmeType
            // 
            this.txtItmeType.Location = new System.Drawing.Point(159, 131);
            this.txtItmeType.Name = "txtItmeType";
            this.txtItmeType.Size = new System.Drawing.Size(101, 21);
            this.txtItmeType.TabIndex = 2;
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(264, 131);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(101, 20);
            this.cbItemType.TabIndex = 3;
            this.cbItemType.Text = "품목선택";
            this.cbItemType.SelectedIndexChanged += new System.EventHandler(this.cbItemType_SelectedIndexChanged);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(159, 305);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(101, 21);
            this.txtNum.TabIndex = 6;
            // 
            // cbAmountType
            // 
            this.cbAmountType.FormattingEnabled = true;
            this.cbAmountType.Location = new System.Drawing.Point(264, 363);
            this.cbAmountType.Name = "cbAmountType";
            this.cbAmountType.Size = new System.Drawing.Size(101, 20);
            this.cbAmountType.TabIndex = 8;
            this.cbAmountType.Text = "단위선택";
            // 
            // dtpDday
            // 
            this.dtpDday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDday.Location = new System.Drawing.Point(159, 418);
            this.dtpDday.Name = "dtpDday";
            this.dtpDday.Size = new System.Drawing.Size(100, 21);
            this.dtpDday.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(161, 495);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(268, 495);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(101, 23);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(159, 363);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(101, 21);
            this.txtAmount.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(263, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 11);
            this.label8.TabIndex = 17;
            this.label8.Text = "* 는 필수입력입니다";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "*냉장고명";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고관리ToolStripMenuItem,
            this.레시피ToolStripMenuItem,
            this.장바구니ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 냉장고관리ToolStripMenuItem
            // 
            this.냉장고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고추가ToolStripMenuItem,
            this.품목추가ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.냉장고관리ToolStripMenuItem.Name = "냉장고관리ToolStripMenuItem";
            this.냉장고관리ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.냉장고관리ToolStripMenuItem.Text = "냉장고관리";
            // 
            // 냉장고추가ToolStripMenuItem
            // 
            this.냉장고추가ToolStripMenuItem.Name = "냉장고추가ToolStripMenuItem";
            this.냉장고추가ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.냉장고추가ToolStripMenuItem.Text = "냉장고 관리";
            // 
            // 품목추가ToolStripMenuItem
            // 
            this.품목추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목추가ToolStripMenuItem1,
            this.품목수정ToolStripMenuItem});
            this.품목추가ToolStripMenuItem.Name = "품목추가ToolStripMenuItem";
            this.품목추가ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.품목추가ToolStripMenuItem.Text = "품목 관리";
            // 
            // 품목추가ToolStripMenuItem1
            // 
            this.품목추가ToolStripMenuItem1.Name = "품목추가ToolStripMenuItem1";
            this.품목추가ToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.품목추가ToolStripMenuItem1.Text = "품목 추가";
            // 
            // 품목수정ToolStripMenuItem
            // 
            this.품목수정ToolStripMenuItem.Name = "품목수정ToolStripMenuItem";
            this.품목수정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.품목수정ToolStripMenuItem.Text = "품목 수정";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 레시피ToolStripMenuItem
            // 
            this.레시피ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피관리ToolStripMenuItem,
            this.요리하기ToolStripMenuItem});
            this.레시피ToolStripMenuItem.Name = "레시피ToolStripMenuItem";
            this.레시피ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.레시피ToolStripMenuItem.Text = "레시피";
            // 
            // 레시피관리ToolStripMenuItem
            // 
            this.레시피관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피추가ToolStripMenuItem,
            this.레시피수정ToolStripMenuItem});
            this.레시피관리ToolStripMenuItem.Name = "레시피관리ToolStripMenuItem";
            this.레시피관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.레시피관리ToolStripMenuItem.Text = "레시피 관리";
            // 
            // 레시피추가ToolStripMenuItem
            // 
            this.레시피추가ToolStripMenuItem.Name = "레시피추가ToolStripMenuItem";
            this.레시피추가ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.레시피추가ToolStripMenuItem.Text = "레시피 추가";
            // 
            // 레시피수정ToolStripMenuItem
            // 
            this.레시피수정ToolStripMenuItem.Name = "레시피수정ToolStripMenuItem";
            this.레시피수정ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.레시피수정ToolStripMenuItem.Text = "레시피 수정";
            // 
            // 요리하기ToolStripMenuItem
            // 
            this.요리하기ToolStripMenuItem.Name = "요리하기ToolStripMenuItem";
            this.요리하기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.요리하기ToolStripMenuItem.Text = "요리하기";
            // 
            // 장바구니ToolStripMenuItem
            // 
            this.장바구니ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장바구니관리ToolStripMenuItem});
            this.장바구니ToolStripMenuItem.Name = "장바구니ToolStripMenuItem";
            this.장바구니ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.장바구니ToolStripMenuItem.Text = "장바구니";
            // 
            // 장바구니관리ToolStripMenuItem
            // 
            this.장바구니관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장바구니에추가ToolStripMenuItem,
            this.구매ToolStripMenuItem});
            this.장바구니관리ToolStripMenuItem.Name = "장바구니관리ToolStripMenuItem";
            this.장바구니관리ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.장바구니관리ToolStripMenuItem.Text = "장바구니 관리";
            // 
            // 장바구니에추가ToolStripMenuItem
            // 
            this.장바구니에추가ToolStripMenuItem.Name = "장바구니에추가ToolStripMenuItem";
            this.장바구니에추가ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.장바구니에추가ToolStripMenuItem.Text = "장바구니에 추가";
            // 
            // 구매ToolStripMenuItem
            // 
            this.구매ToolStripMenuItem.Name = "구매ToolStripMenuItem";
            this.구매ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.구매ToolStripMenuItem.Text = "구매";
            // 
            // cbRefName
            // 
            this.cbRefName.FormattingEnabled = true;
            this.cbRefName.Location = new System.Drawing.Point(159, 73);
            this.cbRefName.Name = "cbRefName";
            this.cbRefName.Size = new System.Drawing.Size(100, 20);
            this.cbRefName.TabIndex = 22;
            this.cbRefName.SelectedIndexChanged += new System.EventHandler(this.cbRefName_SelectedIndexChanged);
            // 
            // cbItemName
            // 
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(264, 189);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(101, 20);
            this.cbItemName.TabIndex = 23;
            this.cbItemName.Text = "품목선택";
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.cbItemName_SelectedIndexChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 534);
            this.Controls.Add(this.cbItemName);
            this.Controls.Add(this.cbRefName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpDday);
            this.Controls.Add(this.cbAmountType);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.txtItmeType);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.rbRef2);
            this.Controls.Add(this.rbRef1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "품목추가";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbRef1;
        private System.Windows.Forms.RadioButton rbRef2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItmeType;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbAmountType;
        private System.Windows.Forms.DateTimePicker dtpDday;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 냉장고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 냉장고추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목추가ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 품목수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 요리하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니에추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRefName;
        private System.Windows.Forms.ComboBox cbItemName;
    }
}