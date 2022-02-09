namespace CSharpPaint
{
    partial class Form1
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
            this.도형그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.네모ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.채우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.굵게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장및불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도형그리기ToolStripMenuItem,
            this.저장및불러오기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // 도형그리기ToolStripMenuItem
            // 
            this.도형그리기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직선ToolStripMenuItem,
            this.원ToolStripMenuItem,
            this.네모ToolStripMenuItem,
            this.toolStripSeparator1,
            this.채우기ToolStripMenuItem,
            this.toolStripSeparator2,
            this.굵게ToolStripMenuItem});
            this.도형그리기ToolStripMenuItem.Name = "도형그리기ToolStripMenuItem";
            this.도형그리기ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.도형그리기ToolStripMenuItem.Text = "도형그리기";
            // 
            // 직선ToolStripMenuItem
            // 
            this.직선ToolStripMenuItem.Name = "직선ToolStripMenuItem";
            this.직선ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.직선ToolStripMenuItem.Text = "직선";
            this.직선ToolStripMenuItem.Click += new System.EventHandler(this.직선ToolStripMenuItem_Click);
            // 
            // 원ToolStripMenuItem
            // 
            this.원ToolStripMenuItem.Name = "원ToolStripMenuItem";
            this.원ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.원ToolStripMenuItem.Text = "원";
            this.원ToolStripMenuItem.Click += new System.EventHandler(this.원ToolStripMenuItem_Click);
            // 
            // 네모ToolStripMenuItem
            // 
            this.네모ToolStripMenuItem.Name = "네모ToolStripMenuItem";
            this.네모ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.네모ToolStripMenuItem.Text = "네모";
            this.네모ToolStripMenuItem.Click += new System.EventHandler(this.네모ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 채우기ToolStripMenuItem
            // 
            this.채우기ToolStripMenuItem.Name = "채우기ToolStripMenuItem";
            this.채우기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.채우기ToolStripMenuItem.Text = "채우기";
            this.채우기ToolStripMenuItem.Click += new System.EventHandler(this.채우기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 굵게ToolStripMenuItem
            // 
            this.굵게ToolStripMenuItem.Name = "굵게ToolStripMenuItem";
            this.굵게ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.굵게ToolStripMenuItem.Text = "굵게";
            this.굵게ToolStripMenuItem.Click += new System.EventHandler(this.굵게ToolStripMenuItem_Click);
            // 
            // 저장및불러오기ToolStripMenuItem
            // 
            this.저장및불러오기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.저장및불러오기ToolStripMenuItem.Name = "저장및불러오기ToolStripMenuItem";
            this.저장및불러오기ToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.저장및불러오기ToolStripMenuItem.Text = "저장 및 불러오기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도형그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 네모ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 채우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 굵게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장및불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
    }
}

