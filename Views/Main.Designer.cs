namespace MemoryPoker.Views
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.PokerPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.後台管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.現有組合清單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreBox
            // 
            this.ScoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScoreBox.Controls.Add(this.ScoreLabel);
            this.ScoreBox.Font = new System.Drawing.Font("新細明體", 20F);
            this.ScoreBox.Location = new System.Drawing.Point(16, 46);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreBox.Size = new System.Drawing.Size(999, 154);
            this.ScoreBox.TabIndex = 1;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "計分表";
            // 
            // PokerPanel
            // 
            this.PokerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PokerPanel.AutoScroll = true;
            this.PokerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PokerPanel.Location = new System.Drawing.Point(16, 207);
            this.PokerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PokerPanel.Name = "PokerPanel";
            this.PokerPanel.Size = new System.Drawing.Size(999, 750);
            this.PokerPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.後台管理ToolStripMenuItem,
            this.離開遊戲ToolStripMenuItem,
            this.現有組合清單ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1033, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.gameToolStripMenuItem.Text = "新遊戲";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.新遊戲ToolStripMenuItem_Click);
            // 
            // 後台管理ToolStripMenuItem
            // 
            this.後台管理ToolStripMenuItem.Name = "後台管理ToolStripMenuItem";
            this.後台管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.後台管理ToolStripMenuItem.Text = "單字管理";
            this.後台管理ToolStripMenuItem.Click += new System.EventHandler(this.後台管理ToolStripMenuItem_Click);
            // 
            // 離開遊戲ToolStripMenuItem
            // 
            this.離開遊戲ToolStripMenuItem.Name = "離開遊戲ToolStripMenuItem";
            this.離開遊戲ToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.離開遊戲ToolStripMenuItem.Text = "離開遊戲";
            this.離開遊戲ToolStripMenuItem.Click += new System.EventHandler(this.離開遊戲ToolStripMenuItem_Click);
            // 
            // 現有組合清單ToolStripMenuItem
            // 
            this.現有組合清單ToolStripMenuItem.Name = "現有組合清單ToolStripMenuItem";
            this.現有組合清單ToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.現有組合清單ToolStripMenuItem.Text = "現有組合清單";
            this.現有組合清單ToolStripMenuItem.Click += new System.EventHandler(this.現有組合清單ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.MemoryTime);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.Location = new System.Drawing.Point(4, 44);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(991, 106);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 754);
            this.Controls.Add(this.PokerPanel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "翻牌遊戲";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ScoreBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Panel PokerPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 後台管理ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 現有組合清單ToolStripMenuItem;
        private System.Windows.Forms.Label ScoreLabel;
    }
}