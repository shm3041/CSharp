namespace Modal_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusLabel = new Label();
            modalButton = new Button();
            modalessButton = new Button();
            menuStrip1 = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            새로만들기ToolStripMenuItem = new ToolStripMenuItem();
            종료ToolStripMenuItem = new ToolStripMenuItem();
            보기ToolStripMenuItem = new ToolStripMenuItem();
            정보보기ToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            프로그램정보ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(32, 39);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(74, 15);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "상태: 대기중";
            // 
            // modalButton
            // 
            modalButton.Location = new Point(192, 71);
            modalButton.Name = "modalButton";
            modalButton.Size = new Size(124, 23);
            modalButton.TabIndex = 1;
            modalButton.Text = "모달 대화상자";
            modalButton.UseVisualStyleBackColor = true;
            // 
            // modalessButton
            // 
            modalessButton.Location = new Point(32, 71);
            modalessButton.Name = "modalessButton";
            modalessButton.Size = new Size(124, 23);
            modalessButton.TabIndex = 2;
            modalessButton.Text = "모달리스 대화상자";
            modalessButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 보기ToolStripMenuItem, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(353, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip2";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 새로만들기ToolStripMenuItem, 종료ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(43, 20);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            새로만들기ToolStripMenuItem.Size = new Size(180, 22);
            새로만들기ToolStripMenuItem.Text = "새로 만들기";
            새로만들기ToolStripMenuItem.Click += 새로만들기ToolStripMenuItem_Click;
            // 
            // 종료ToolStripMenuItem
            // 
            종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            종료ToolStripMenuItem.Size = new Size(180, 22);
            종료ToolStripMenuItem.Text = "종료";
            종료ToolStripMenuItem.Click += 종료ToolStripMenuItem_Click;
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 정보보기ToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(43, 20);
            보기ToolStripMenuItem.Text = "보기";
            // 
            // 정보보기ToolStripMenuItem
            // 
            정보보기ToolStripMenuItem.Name = "정보보기ToolStripMenuItem";
            정보보기ToolStripMenuItem.Size = new Size(126, 22);
            정보보기ToolStripMenuItem.Text = "정보 보기";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 프로그램정보ToolStripMenuItem });
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(55, 20);
            도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            프로그램정보ToolStripMenuItem.Size = new Size(150, 22);
            프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 106);
            Controls.Add(modalessButton);
            Controls.Add(modalButton);
            Controls.Add(statusLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Winform Menu Example";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusLabel;
        private Button modalButton;
        private Button modalessButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private ToolStripMenuItem 종료ToolStripMenuItem;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private ToolStripMenuItem 정보보기ToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem 프로그램정보ToolStripMenuItem;
    }
}
