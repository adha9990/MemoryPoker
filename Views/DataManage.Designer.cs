namespace MemoryPoker.Views
{
    partial class DataManage
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
            this.DataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "單字管理";
            // 
            // DataTableLayoutPanel
            // 
            this.DataTableLayoutPanel.AutoScroll = true;
            this.DataTableLayoutPanel.ColumnCount = 5;
            this.DataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.DataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DataTableLayoutPanel.Location = new System.Drawing.Point(12, 45);
            this.DataTableLayoutPanel.Name = "DataTableLayoutPanel";
            this.DataTableLayoutPanel.RowCount = 1;
            this.DataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DataTableLayoutPanel.Size = new System.Drawing.Size(428, 451);
            this.DataTableLayoutPanel.TabIndex = 1;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(12, 12);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "新增單字";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(338, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "離開";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 508);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DataTableLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "DataManage";
            this.Text = "DataManage";
            this.Load += new System.EventHandler(this.DataManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel DataTableLayoutPanel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ExitButton;
    }
}