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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.냉장고관리ToolStripMenuItem,
            this.레시피ToolStripMenuItem,
            this.장바구니ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
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
            this.품목추가ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.품목추가ToolStripMenuItem.Text = "품목 관리";
            // 
            // 품목추가ToolStripMenuItem1
            // 
            this.품목추가ToolStripMenuItem1.Name = "품목추가ToolStripMenuItem1";
            this.품목추가ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.품목추가ToolStripMenuItem1.Text = "품목 추가";
            this.품목추가ToolStripMenuItem1.Click += new System.EventHandler(this.품목추가ToolStripMenuItem1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(806, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "품목명";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "소비 갯수";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "단위";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "소비 량";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "품목종류";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "냉장고 조회";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "소비";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 178);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목소비";
            // 
            // MyRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyRef";
            this.Text = "내냉장고";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

