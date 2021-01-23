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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.後台管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.現有組合清單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定記憶時間ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PokerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScoreBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreBox
            // 
            this.ScoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreBox.BackColor = System.Drawing.Color.SteelBlue;
            this.ScoreBox.Controls.Add(this.ScoreLabel);
            this.ScoreBox.Font = new System.Drawing.Font("新細明體", 20F);
            this.ScoreBox.ForeColor = System.Drawing.Color.White;
            this.ScoreBox.Location = new System.Drawing.Point(12, 37);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(749, 123);
            this.ScoreBox.TabIndex = 1;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "計分表";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(3, 35);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(743, 85);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.後台管理ToolStripMenuItem,
            this.現有組合清單ToolStripMenuItem,
            this.設定記憶時間ToolStripMenuItem,
            this.離開遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gameToolStripMenuItem.Text = "新遊戲";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.新遊戲ToolStripMenuItem_Click);
            // 
            // 後台管理ToolStripMenuItem
            // 
            this.後台管理ToolStripMenuItem.Name = "後台管理ToolStripMenuItem";
            this.後台管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.後台管理ToolStripMenuItem.Text = "單字管理";
            this.後台管理ToolStripMenuItem.Click += new System.EventHandler(this.後台管理ToolStripMenuItem_Click);
            // 
            // 現有組合清單ToolStripMenuItem
            // 
            this.現有組合清單ToolStripMenuItem.Name = "現有組合清單ToolStripMenuItem";
            this.現有組合清單ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.現有組合清單ToolStripMenuItem.Text = "現有組合清單";
            this.現有組合清單ToolStripMenuItem.Click += new System.EventHandler(this.現有組合清單ToolStripMenuItem_Click);
            // 
            // 設定記憶時間ToolStripMenuItem
            // 
            this.設定記憶時間ToolStripMenuItem.Name = "設定記憶時間ToolStripMenuItem";
            this.設定記憶時間ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.設定記憶時間ToolStripMenuItem.Text = "設定記憶時間";
            this.設定記憶時間ToolStripMenuItem.Click += new System.EventHandler(this.設定記憶時間ToolStripMenuItem_Click);
            // 
            // 離開遊戲ToolStripMenuItem
            // 
            this.離開遊戲ToolStripMenuItem.Name = "離開遊戲ToolStripMenuItem";
            this.離開遊戲ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.離開遊戲ToolStripMenuItem.Text = "離開遊戲";
            this.離開遊戲ToolStripMenuItem.Click += new System.EventHandler(this.離開遊戲ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.MemoryTime);
            // 
            // PokerFlowPanel
            // 
            this.PokerFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PokerFlowPanel.AutoSize = true;
            this.PokerFlowPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.PokerFlowPanel.Location = new System.Drawing.Point(12, 166);
            this.PokerFlowPanel.Name = "PokerFlowPanel";
            this.PokerFlowPanel.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.PokerFlowPanel.Size = new System.Drawing.Size(751, 425);
            this.PokerFlowPanel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(775, 603);
            this.Controls.Add(this.PokerFlowPanel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 後台管理ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 現有組合清單ToolStripMenuItem;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.FlowLayoutPanel PokerFlowPanel;
        private System.Windows.Forms.ToolStripMenuItem 設定記憶時間ToolStripMenuItem;
    }
}