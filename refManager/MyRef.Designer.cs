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
            this.lblUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTypeSE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnWaste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countPanel = new System.Windows.Forms.Panel();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.amountPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.rbCount = new System.Windows.Forms.RadioButton();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefitems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.countPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.amountPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
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
            this.냉장고관리ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.냉장고관리ToolStripMenuItem.Text = "냉장고관리";
            // 
            // 냉장고추가ToolStripMenuItem
            // 
            this.냉장고추가ToolStripMenuItem.Name = "냉장고추가ToolStripMenuItem";
            this.냉장고추가ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.냉장고추가ToolStripMenuItem.Text = "냉장고 관리";
            this.냉장고추가ToolStripMenuItem.Click += new System.EventHandler(this.냉장고추가ToolStripMenuItem_Click);
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
            this.품목추가ToolStripMenuItem1.Click += new System.EventHandler(this.품목추가ToolStripMenuItem1_Click);
            // 
            // 품목수정ToolStripMenuItem
            // 
            this.품목수정ToolStripMenuItem.Name = "품목수정ToolStripMenuItem";
            this.품목수정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.품목수정ToolStripMenuItem.Text = "품목 수정";
            this.품목수정ToolStripMenuItem.Click += new System.EventHandler(this.품목수정ToolStripMenuItem_Click);
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
            // dgvRefitems
            // 
            this.dgvRefitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefitems.Location = new System.Drawing.Point(12, 225);
            this.dgvRefitems.Name = "dgvRefitems";
            this.dgvRefitems.RowHeadersWidth = 51;
            this.dgvRefitems.RowTemplate.Height = 23;
            this.dgvRefitems.Size = new System.Drawing.Size(888, 355);
            this.dgvRefitems.TabIndex = 1;
            this.dgvRefitems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefitems_CellDoubleClick);
            this.dgvRefitems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRefitems_DataBindingComplete);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 46);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "품목명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "소비 갯수";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(163, 22);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 12);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "단위";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "소비 량";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(57, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnTypeSE
            // 
            this.btnTypeSE.Location = new System.Drawing.Point(195, 18);
            this.btnTypeSE.Name = "btnTypeSE";
            this.btnTypeSE.Size = new System.Drawing.Size(75, 23);
            this.btnTypeSE.TabIndex = 13;
            this.btnTypeSE.Text = "검색";
            this.btnTypeSE.UseVisualStyleBackColor = true;
            this.btnTypeSE.Click += new System.EventHandler(this.btnTypeSE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "품목종류";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(792, 149);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "냉장고 조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnWaste
            // 
            this.btnWaste.Location = new System.Drawing.Point(698, 149);
            this.btnWaste.Name = "btnWaste";
            this.btnWaste.Size = new System.Drawing.Size(75, 23);
            this.btnWaste.TabIndex = 2;
            this.btnWaste.Text = "소비";
            this.btnWaste.UseVisualStyleBackColor = true;
            this.btnWaste.Click += new System.EventHandler(this.btnWaste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countPanel);
            this.groupBox1.Controls.Add(this.amountPanel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbAmount);
            this.groupBox1.Controls.Add(this.rbCount);
            this.groupBox1.Controls.Add(this.cbItemType);
            this.groupBox1.Controls.Add(this.btnTypeSE);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnWaste);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 178);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목소비";
            // 
            // countPanel
            // 
            this.countPanel.Controls.Add(this.numCount);
            this.countPanel.Controls.Add(this.label3);
            this.countPanel.Location = new System.Drawing.Point(0, 114);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(223, 58);
            this.countPanel.TabIndex = 26;
            this.countPanel.Visible = false;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(89, 21);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(100, 21);
            this.numCount.TabIndex = 23;
            // 
            // amountPanel
            // 
            this.amountPanel.Controls.Add(this.txtAmount);
            this.amountPanel.Controls.Add(this.label5);
            this.amountPanel.Controls.Add(this.lblUnit);
            this.amountPanel.Location = new System.Drawing.Point(6, 114);
            this.amountPanel.Name = "amountPanel";
            this.amountPanel.Size = new System.Drawing.Size(212, 58);
            this.amountPanel.TabIndex = 25;
            this.amountPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "소비 방법";
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(156, 79);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(47, 16);
            this.rbAmount.TabIndex = 22;
            this.rbAmount.TabStop = true;
            this.rbAmount.Text = "용량";
            this.rbAmount.UseVisualStyleBackColor = true;
            this.rbAmount.CheckedChanged += new System.EventHandler(this.rbAmount_CheckedChanged);
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Location = new System.Drawing.Point(90, 79);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(47, 16);
            this.rbCount.TabIndex = 21;
            this.rbCount.TabStop = true;
            this.rbCount.Text = "갯수";
            this.rbCount.UseVisualStyleBackColor = true;
            this.rbCount.CheckedChanged += new System.EventHandler(this.rbAmount_CheckedChanged);
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(89, 20);
            this.cbItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(100, 20);
            this.cbItemType.TabIndex = 16;
            // 
            // MyRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRefitems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyRef";
            this.Text = "내냉장고";
            this.Load += new System.EventHandler(this.MyRef_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefitems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.amountPanel.ResumeLayout(false);
            this.amountPanel.PerformLayout();
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
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTypeSE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWaste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.Panel countPanel;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Panel amountPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.RadioButton rbCount;
    }
}

