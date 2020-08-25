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
            this.smiOverwrite = new System.Windows.Forms.ToolStripMenuItem();
            this.AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fdFont = new System.Windows.Forms.FontDialog();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "ofdFileOpen";
            // 
            // rtbTextEditer
            // 
            this.rtbTextEditer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextEditer.EnableAutoDragDrop = true;
            this.rtbTextEditer.Location = new System.Drawing.Point(0, 24);
            this.rtbTextEditer.Name = "rtbTextEditer";
            this.rtbTextEditer.Size = new System.Drawing.Size(792, 409);
            this.rtbTextEditer.TabIndex = 0;
            this.rtbTextEditer.Text = "";
            this.rtbTextEditer.TextChanged += new System.EventHandler(this.rtbTextEditer_TextChanged);
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
            this.smiOverwrite,
            this.AToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmiExit});
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
            // smiOverwrite
            // 
            this.smiOverwrite.Name = "smiOverwrite";
            this.smiOverwrite.Size = new System.Drawing.Size(181, 22);
            this.smiOverwrite.Text = "上書き保存(&S)";
            this.smiOverwrite.Click += new System.EventHandler(this.smiOverwrite_Click);
            // 
            // AToolStripMenuItem
            // 
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            this.AToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            this.AToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(181, 22);
            this.tsmiExit.Text = "終了(&F4)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.toolStripSeparator2,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator4,
            this.tsmiDelete,
            this.toolStripSeparator3,
            this.tsmiFont,
            this.tsmiColor});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            this.編集EToolStripMenuItem.Click += new System.EventHandler(this.編集EToolStripMenuItem_Click);
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(180, 22);
            this.tsmiUndo.Text = "元に戻す(&U)";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(180, 22);
            this.tsmiRedo.Text = "やり直し(&R)";
            this.tsmiRedo.Click += new System.EventHandler(this.tsmiRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(180, 22);
            this.tsmiCut.Text = "切り取り(&T)";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "コピー(&T)";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaste.Text = "貼り付け(&P)";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "削除(&D)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
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
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(180, 22);
            this.tsmiFont.Text = "フォント";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiColor
            // 
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiColor.Text = "色";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
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
        private System.Windows.Forms.ToolStripMenuItem smiOverwrite;
        private System.Windows.Forms.ToolStripMenuItem AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.FontDialog fdFont;
        private System.Windows.Forms.ColorDialog cdColor;
    }
}

