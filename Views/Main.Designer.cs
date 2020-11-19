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
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PokerPanel = new System.Windows.Forms.Panel();
            this.ScoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.ScoreLabel);
            this.ScoreBox.Font = new System.Drawing.Font("新細明體", 20F);
            this.ScoreBox.Location = new System.Drawing.Point(13, 13);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(749, 123);
            this.ScoreBox.TabIndex = 1;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "計分表";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(377, 56);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(25, 27);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "0";
            // 
            // PokerPanel
            // 
            this.PokerPanel.Location = new System.Drawing.Point(13, 143);
            this.PokerPanel.Name = "PokerPanel";
            this.PokerPanel.Size = new System.Drawing.Size(749, 600);
            this.PokerPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 754);
            this.Controls.Add(this.PokerPanel);
            this.Controls.Add(this.ScoreBox);
            this.Name = "Main";
            this.Text = "翻牌遊戲";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ScoreBox.ResumeLayout(false);
            this.ScoreBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel PokerPanel;
    }
}