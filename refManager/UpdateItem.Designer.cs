namespace refManager
{
    partial class UpdateItem
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
            this.dgvUpdateItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
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
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.cbRefName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDday = new System.Windows.Forms.DateTimePicker();
            this.cbAmountType = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.txtItmeType = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.rbRef2 = new System.Windows.Forms.RadioButton();
            this.rbRef1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRefName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUpdateItems
            // 
            this.dgvUpdateItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateItems.Location = new System.Drawing.Point(14, 56);
            this.dgvUpdateItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUpdateItems.Name = "dgvUpdateItems";
            this.dgvUpdateItems.RowHeadersWidth = 51;
            this.dgvUpdateItems.RowTemplate.Height = 23;
            this.dgvUpdateItems.Size = new System.Drawing.Size(469, 691);
            this.dgvUpdateItems.TabIndex = 0;
            this.dgvUpdateItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateItems_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRefName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbItemName);
            this.groupBox1.Controls.Add(this.cbRefName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.dtpDday);
            this.groupBox1.Controls.Add(this.cbAmountType);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.cbItemType);
            this.groupBox1.Controls.Add(this.txtItmeType);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.rbRef2);
            this.groupBox1.Controls.Add(this.rbRef1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(512, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(477, 691);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수정";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고관리ToolStripMenuItem,
            this.레시피ToolStripMenuItem,
            this.장바구니ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip2.TabIndex = 39;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 냉장고관리ToolStripMenuItem
            // 
            this.냉장고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고추가ToolStripMenuItem,
            this.품목추가ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.냉장고관리ToolStripMenuItem.Name = "냉장고관리ToolStripMenuItem";
            this.냉장고관리ToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.냉장고관리ToolStripMenuItem.Text = "냉장고관리";
            // 
            // 냉장고추가ToolStripMenuItem
            // 
            this.냉장고추가ToolStripMenuItem.Name = "냉장고추가ToolStripMenuItem";
            this.냉장고추가ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.냉장고추가ToolStripMenuItem.Text = "냉장고 관리";
            // 
            // 품목추가ToolStripMenuItem
            // 
            this.품목추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목추가ToolStripMenuItem1,
            this.품목수정ToolStripMenuItem});
            this.품목추가ToolStripMenuItem.Name = "품목추가ToolStripMenuItem";
            this.품목추가ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.품목추가ToolStripMenuItem.Text = "품목 관리";
            // 
            // 품목추가ToolStripMenuItem1
            // 
            this.품목추가ToolStripMenuItem1.Name = "품목추가ToolStripMenuItem1";
            this.품목추가ToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.품목추가ToolStripMenuItem1.Text = "품목 추가";
            // 
            // 품목수정ToolStripMenuItem
            // 
            this.품목수정ToolStripMenuItem.Name = "품목수정ToolStripMenuItem";
            this.품목수정ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.품목수정ToolStripMenuItem.Text = "품목 수정";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 레시피ToolStripMenuItem
            // 
            this.레시피ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피관리ToolStripMenuItem,
            this.요리하기ToolStripMenuItem});
            this.레시피ToolStripMenuItem.Name = "레시피ToolStripMenuItem";
            this.레시피ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.레시피ToolStripMenuItem.Text = "레시피";
            // 
            // 레시피관리ToolStripMenuItem
            // 
            this.레시피관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피추가ToolStripMenuItem,
            this.레시피수정ToolStripMenuItem});
            this.레시피관리ToolStripMenuItem.Name = "레시피관리ToolStripMenuItem";
            this.레시피관리ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.레시피관리ToolStripMenuItem.Text = "레시피 관리";
            // 
            // 레시피추가ToolStripMenuItem
            // 
            this.레시피추가ToolStripMenuItem.Name = "레시피추가ToolStripMenuItem";
            this.레시피추가ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.레시피추가ToolStripMenuItem.Text = "레시피 추가";
            // 
            // 레시피수정ToolStripMenuItem
            // 
            this.레시피수정ToolStripMenuItem.Name = "레시피수정ToolStripMenuItem";
            this.레시피수정ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.레시피수정ToolStripMenuItem.Text = "레시피 수정";
            // 
            // 요리하기ToolStripMenuItem
            // 
            this.요리하기ToolStripMenuItem.Name = "요리하기ToolStripMenuItem";
            this.요리하기ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.요리하기ToolStripMenuItem.Text = "요리하기";
            // 
            // 장바구니ToolStripMenuItem
            // 
            this.장바구니ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장바구니관리ToolStripMenuItem});
            this.장바구니ToolStripMenuItem.Name = "장바구니ToolStripMenuItem";
            this.장바구니ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.장바구니ToolStripMenuItem.Text = "장바구니";
            // 
            // 장바구니관리ToolStripMenuItem
            // 
            this.장바구니관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장바구니에추가ToolStripMenuItem,
            this.구매ToolStripMenuItem});
            this.장바구니관리ToolStripMenuItem.Name = "장바구니관리ToolStripMenuItem";
            this.장바구니관리ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.장바구니관리ToolStripMenuItem.Text = "장바구니 관리";
            // 
            // 장바구니에추가ToolStripMenuItem
            // 
            this.장바구니에추가ToolStripMenuItem.Name = "장바구니에추가ToolStripMenuItem";
            this.장바구니에추가ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.장바구니에추가ToolStripMenuItem.Text = "장바구니에 추가";
            // 
            // 구매ToolStripMenuItem
            // 
            this.구매ToolStripMenuItem.Name = "구매ToolStripMenuItem";
            this.구매ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.구매ToolStripMenuItem.Text = "구매";
            // 
            // cbItemName
            // 
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(291, 212);
            this.cbItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(115, 23);
            this.cbItemName.TabIndex = 44;
            this.cbItemName.Text = "품목선택";
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.cbItemName_SelectedIndexChanged);
            // 
            // cbRefName
            // 
            this.cbRefName.FormattingEnabled = true;
            this.cbRefName.Location = new System.Drawing.Point(291, 68);
            this.cbRefName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRefName.Name = "cbRefName";
            this.cbRefName.Size = new System.Drawing.Size(114, 23);
            this.cbRefName.TabIndex = 43;
            this.cbRefName.SelectedIndexChanged += new System.EventHandler(this.cbRefName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "*냉장고명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(290, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 14);
            this.label8.TabIndex = 41;
            this.label8.Text = "* 는 필수입력입니다";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(171, 430);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(115, 25);
            this.txtAmount.TabIndex = 36;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(295, 595);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(115, 29);
            this.btnCancle.TabIndex = 40;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(173, 595);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 29);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpDday
            // 
            this.dtpDday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDday.Location = new System.Drawing.Point(171, 498);
            this.dtpDday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDday.Name = "dtpDday";
            this.dtpDday.Size = new System.Drawing.Size(114, 25);
            this.dtpDday.TabIndex = 38;
            // 
            // cbAmountType
            // 
            this.cbAmountType.FormattingEnabled = true;
            this.cbAmountType.Location = new System.Drawing.Point(291, 430);
            this.cbAmountType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAmountType.Name = "cbAmountType";
            this.cbAmountType.Size = new System.Drawing.Size(115, 23);
            this.cbAmountType.TabIndex = 37;
            this.cbAmountType.Text = "단위선택";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(171, 357);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(115, 25);
            this.txtNum.TabIndex = 34;
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(291, 140);
            this.cbItemType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(115, 23);
            this.cbItemType.TabIndex = 29;
            this.cbItemType.Text = "품목선택";
            this.cbItemType.SelectedIndexChanged += new System.EventHandler(this.cbItemType_SelectedIndexChanged);
            // 
            // txtItmeType
            // 
            this.txtItmeType.Location = new System.Drawing.Point(171, 140);
            this.txtItmeType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItmeType.Name = "txtItmeType";
            this.txtItmeType.Size = new System.Drawing.Size(115, 25);
            this.txtItmeType.TabIndex = 26;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(171, 212);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(115, 25);
            this.txtItemName.TabIndex = 25;
            // 
            // rbRef2
            // 
            this.rbRef2.AutoSize = true;
            this.rbRef2.Location = new System.Drawing.Point(236, 286);
            this.rbRef2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRef2.Name = "rbRef2";
            this.rbRef2.Size = new System.Drawing.Size(58, 19);
            this.rbRef2.TabIndex = 32;
            this.rbRef2.TabStop = true;
            this.rbRef2.Text = "냉동";
            this.rbRef2.UseVisualStyleBackColor = true;
            // 
            // rbRef1
            // 
            this.rbRef1.AutoSize = true;
            this.rbRef1.Location = new System.Drawing.Point(171, 286);
            this.rbRef1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRef1.Name = "rbRef1";
            this.rbRef1.Size = new System.Drawing.Size(58, 19);
            this.rbRef1.TabIndex = 30;
            this.rbRef1.TabStop = true;
            this.rbRef1.Text = "냉장";
            this.rbRef1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "* 유통기한";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "용량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "* 갯수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "* 보관장소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "* 품목종류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "* 품목명";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(54, 595);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 29);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtRefName
            // 
            this.txtRefName.Location = new System.Drawing.Point(171, 68);
            this.txtRefName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRefName.Name = "txtRefName";
            this.txtRefName.Size = new System.Drawing.Size(115, 25);
            this.txtRefName.TabIndex = 46;
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 806);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUpdateItems);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateItem";
            this.Text = "수정";
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
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
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.ComboBox cbRefName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDday;
        private System.Windows.Forms.ComboBox cbAmountType;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.TextBox txtItmeType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.RadioButton rbRef2;
        private System.Windows.Forms.RadioButton rbRef1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRefName;
    }
}