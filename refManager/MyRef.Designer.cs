namespace refManager
{
    partial class MyRef
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.dgvRefitems = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTypeSE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnWaste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefitems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 냉장고관리ToolStripMenuItem
            // 
            this.냉장고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고추가ToolStripMenuItem,
            this.품목추가ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.냉장고관리ToolStripMenuItem.Name = "냉장고관리ToolStripMenuItem";
            this.냉장고관리ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.냉장고관리ToolStripMenuItem.Text = "냉장고관리";
            // 
            // 냉장고추가ToolStripMenuItem
            // 
            this.냉장고추가ToolStripMenuItem.Name = "냉장고추가ToolStripMenuItem";
            this.냉장고추가ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.냉장고추가ToolStripMenuItem.Text = "냉장고 관리";
            this.냉장고추가ToolStripMenuItem.Click += new System.EventHandler(this.냉장고추가ToolStripMenuItem_Click);
            // 
            // 품목추가ToolStripMenuItem
            // 
            this.품목추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목추가ToolStripMenuItem1,
            this.품목수정ToolStripMenuItem});
            this.품목추가ToolStripMenuItem.Name = "품목추가ToolStripMenuItem";
            this.품목추가ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.품목추가ToolStripMenuItem.Text = "품목 관리";
            // 
            // 품목추가ToolStripMenuItem1
            // 
            this.품목추가ToolStripMenuItem1.Name = "품목추가ToolStripMenuItem1";
            this.품목추가ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.품목추가ToolStripMenuItem1.Text = "품목 추가";
            this.품목추가ToolStripMenuItem1.Click += new System.EventHandler(this.품목추가ToolStripMenuItem1_Click);
            // 
            // 품목수정ToolStripMenuItem
            // 
            this.품목수정ToolStripMenuItem.Name = "품목수정ToolStripMenuItem";
            this.품목수정ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.품목수정ToolStripMenuItem.Text = "품목 수정";
            this.품목수정ToolStripMenuItem.Click += new System.EventHandler(this.품목수정ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 레시피ToolStripMenuItem
            // 
            this.레시피ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피관리ToolStripMenuItem,
            this.요리하기ToolStripMenuItem});
            this.레시피ToolStripMenuItem.Name = "레시피ToolStripMenuItem";
            this.레시피ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.레시피ToolStripMenuItem.Text = "레시피";
            // 
            // 레시피관리ToolStripMenuItem
            // 
            this.레시피관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.레시피추가ToolStripMenuItem,
            this.레시피수정ToolStripMenuItem});
            this.레시피관리ToolStripMenuItem.Name = "레시피관리ToolStripMenuItem";
            this.레시피관리ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.요리하기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.요리하기ToolStripMenuItem.Text = "요리하기";
            // 
            // 장바구니ToolStripMenuItem
            // 
            this.장바구니ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장바구니관리ToolStripMenuItem});
            this.장바구니ToolStripMenuItem.Name = "장바구니ToolStripMenuItem";
            this.장바구니ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
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
            // dgvRefitems
            // 
            this.dgvRefitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefitems.Location = new System.Drawing.Point(14, 281);
            this.dgvRefitems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRefitems.Name = "dgvRefitems";
            this.dgvRefitems.RowHeadersWidth = 51;
            this.dgvRefitems.RowTemplate.Height = 23;
            this.dgvRefitems.Size = new System.Drawing.Size(921, 444);
            this.dgvRefitems.TabIndex = 1;
            this.dgvRefitems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefitems_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 25);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "품목명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "소비 갯수";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(103, 126);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(114, 25);
            this.txtCount.TabIndex = 0;
            this.txtCount.Leave += new System.EventHandler(this.txtCount_Leave);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(223, 180);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(37, 15);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "단위";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "소비 량";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(103, 177);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(114, 25);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnTypeSE
            // 
            this.btnTypeSE.Location = new System.Drawing.Point(353, 21);
            this.btnTypeSE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTypeSE.Name = "btnTypeSE";
            this.btnTypeSE.Size = new System.Drawing.Size(86, 29);
            this.btnTypeSE.TabIndex = 13;
            this.btnTypeSE.Text = "검색";
            this.btnTypeSE.UseVisualStyleBackColor = true;
            this.btnTypeSE.Click += new System.EventHandler(this.btnTypeSE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "품목종류";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(103, 25);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(114, 25);
            this.txtType.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(807, 180);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(97, 29);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "냉장고 조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnWaste
            // 
            this.btnWaste.Location = new System.Drawing.Point(699, 180);
            this.btnWaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWaste.Name = "btnWaste";
            this.btnWaste.Size = new System.Drawing.Size(86, 29);
            this.btnWaste.TabIndex = 2;
            this.btnWaste.Text = "소비";
            this.btnWaste.UseVisualStyleBackColor = true;
            this.btnWaste.Click += new System.EventHandler(this.btnWaste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbItemType);
            this.groupBox1.Controls.Add(this.btnTypeSE);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnWaste);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(921, 222);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목소비";
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(226, 25);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(121, 23);
            this.cbItemType.TabIndex = 16;
            // 
            // MyRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 740);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRefitems);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyRef";
            this.Text = "내냉장고";
            this.Load += new System.EventHandler(this.MyRef_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefitems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 냉장고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 냉장고추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 요리하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목추가ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 레시피추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니에추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목수정ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRefitems;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTypeSE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWaste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbItemType;
    }
}

