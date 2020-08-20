namespace TextEditer31114
{
    partial class TextEditer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.rtbTextEditer = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了F4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "ofdFileOpen";
            // 
            // rtbTextEditer
            // 
            this.rtbTextEditer.Location = new System.Drawing.Point(204, 83);
            this.rtbTextEditer.Name = "rtbTextEditer";
            this.rtbTextEditer.Size = new System.Drawing.Size(353, 268);
            this.rtbTextEditer.TabIndex = 0;
            this.rtbTextEditer.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.ヘルプCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューFToolStripMenuItem
            // 
            this.メニューFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.OToolStripMenuItem,
            this.上書き保存SToolStripMenuItem,
            this.AToolStripMenuItem,
            this.終了F4ToolStripMenuItem});
            this.メニューFToolStripMenuItem.Name = "メニューFToolStripMenuItem";
            this.メニューFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.メニューFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規作成NToolStripMenuItem
            // 
            this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
            this.新規作成NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.新規作成NToolStripMenuItem.Text = "新規作成(&N)";
            // 
            // OToolStripMenuItem
            // 
            this.OToolStripMenuItem.Name = "OToolStripMenuItem";
            this.OToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.OToolStripMenuItem.Text = "開く(&O)...";
            this.OToolStripMenuItem.Click += new System.EventHandler(this.OToolStripMenuItem_Click);
            // 
            // 上書き保存SToolStripMenuItem
            // 
            this.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem";
            this.上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // AToolStripMenuItem
            // 
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            this.AToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            this.AToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // 終了F4ToolStripMenuItem
            // 
            this.終了F4ToolStripMenuItem.Name = "終了F4ToolStripMenuItem";
            this.終了F4ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.終了F4ToolStripMenuItem.Text = "終了(&F4)";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            // 
            // ヘルプCToolStripMenuItem
            // 
            this.ヘルプCToolStripMenuItem.Name = "ヘルプCToolStripMenuItem";
            this.ヘルプCToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ヘルプCToolStripMenuItem.Text = "ヘルプ(&C)";
            // 
            // TextEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 433);
            this.Controls.Add(this.rtbTextEditer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditer";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.RichTextBox rtbTextEditer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了F4ToolStripMenuItem;
    }
}

