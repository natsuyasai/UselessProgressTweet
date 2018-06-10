namespace UselessProgressTweet
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.AuthenticationButton = new System.Windows.Forms.Button();
      this.PINCode = new System.Windows.Forms.TextBox();
      this.PINOkButton = new System.Windows.Forms.Button();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.TimeText = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TimeButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.OutButton = new System.Windows.Forms.Button();
      this.GoodButton = new System.Windows.Forms.Button();
      this.ツイートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // AuthenticationButton
      // 
      this.AuthenticationButton.Location = new System.Drawing.Point(44, 26);
      this.AuthenticationButton.Name = "AuthenticationButton";
      this.AuthenticationButton.Size = new System.Drawing.Size(75, 23);
      this.AuthenticationButton.TabIndex = 0;
      this.AuthenticationButton.Text = "認証";
      this.AuthenticationButton.UseVisualStyleBackColor = true;
      this.AuthenticationButton.Click += new System.EventHandler(this.AuthenticationButton_Click);
      // 
      // PINCode
      // 
      this.PINCode.Location = new System.Drawing.Point(13, 58);
      this.PINCode.Name = "PINCode";
      this.PINCode.Size = new System.Drawing.Size(100, 19);
      this.PINCode.TabIndex = 1;
      // 
      // PINOkButton
      // 
      this.PINOkButton.Location = new System.Drawing.Point(119, 58);
      this.PINOkButton.Name = "PINOkButton";
      this.PINOkButton.Size = new System.Drawing.Size(35, 23);
      this.PINOkButton.TabIndex = 2;
      this.PINOkButton.Text = "OK";
      this.PINOkButton.UseVisualStyleBackColor = true;
      this.PINOkButton.Click += new System.EventHandler(this.PINOkButton_Click);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIcon1.BalloonTipText = "進捗どうですか？";
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "進捗";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
      this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem,
            this.ツイートToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
      // 
      // 終了ToolStripMenuItem
      // 
      this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
      this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.終了ToolStripMenuItem.Text = "終了";
      this.終了ToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
      // 
      // TimeText
      // 
      this.TimeText.Location = new System.Drawing.Point(13, 96);
      this.TimeText.Name = "TimeText";
      this.TimeText.Size = new System.Drawing.Size(39, 19);
      this.TimeText.TabIndex = 3;
      this.TimeText.Text = "60";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 12);
      this.label1.TabIndex = 4;
      this.label1.Text = "分おきに通知";
      // 
      // TimeButton
      // 
      this.TimeButton.Location = new System.Drawing.Point(133, 94);
      this.TimeButton.Name = "TimeButton";
      this.TimeButton.Size = new System.Drawing.Size(42, 23);
      this.TimeButton.TabIndex = 5;
      this.TimeButton.Text = "更新";
      this.TimeButton.UseVisualStyleBackColor = true;
      this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 3600000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // OutButton
      // 
      this.OutButton.Location = new System.Drawing.Point(13, 26);
      this.OutButton.Name = "OutButton";
      this.OutButton.Size = new System.Drawing.Size(75, 23);
      this.OutButton.TabIndex = 7;
      this.OutButton.Text = "ダメです。";
      this.OutButton.UseVisualStyleBackColor = true;
      this.OutButton.Visible = false;
      this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
      // 
      // GoodButton
      // 
      this.GoodButton.Location = new System.Drawing.Point(94, 26);
      this.GoodButton.Name = "GoodButton";
      this.GoodButton.Size = new System.Drawing.Size(75, 23);
      this.GoodButton.TabIndex = 8;
      this.GoodButton.Text = "OKです。";
      this.GoodButton.UseVisualStyleBackColor = true;
      this.GoodButton.Visible = false;
      this.GoodButton.Click += new System.EventHandler(this.GoodButton_Click);
      // 
      // ツイートToolStripMenuItem
      // 
      this.ツイートToolStripMenuItem.Name = "ツイートToolStripMenuItem";
      this.ツイートToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.ツイートToolStripMenuItem.Text = "ツイート";
      this.ツイートToolStripMenuItem.Click += new System.EventHandler(this.TweetToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(187, 138);
      this.Controls.Add(this.GoodButton);
      this.Controls.Add(this.OutButton);
      this.Controls.Add(this.TimeButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TimeText);
      this.Controls.Add(this.PINOkButton);
      this.Controls.Add(this.PINCode);
      this.Controls.Add(this.AuthenticationButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "進捗どうですか？";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthenticationButton;
        private System.Windows.Forms.TextBox PINCode;
        private System.Windows.Forms.Button PINOkButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button GoodButton;
        private System.Windows.Forms.ToolStripMenuItem ツイートToolStripMenuItem;

    }
}

