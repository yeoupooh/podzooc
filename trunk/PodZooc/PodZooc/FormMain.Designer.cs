namespace PodZooc
{
    partial class FormMain
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.listBoxFeeds = new System.Windows.Forms.ListBox();
            this.listBoxPods = new System.Windows.Forms.ListBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMain)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(174, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(174, 247);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.Size = new System.Drawing.Size(100, 46);
            this.textBoxDebug.TabIndex = 17;
            this.textBoxDebug.Visible = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbout.Location = new System.Drawing.Point(174, 163);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(100, 30);
            this.buttonAbout.TabIndex = 16;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(174, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainerMain.Location = new System.Drawing.Point(12, 12);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listBoxFeeds);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.listBoxPods);
            this.splitContainerMain.Size = new System.Drawing.Size(156, 291);
            this.splitContainerMain.SplitterDistance = 69;
            this.splitContainerMain.SplitterWidth = 10;
            this.splitContainerMain.TabIndex = 14;
            // 
            // listBoxFeeds
            // 
            this.listBoxFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFeeds.FormattingEnabled = true;
            this.listBoxFeeds.ItemHeight = 12;
            this.listBoxFeeds.Location = new System.Drawing.Point(0, 0);
            this.listBoxFeeds.Name = "listBoxFeeds";
            this.listBoxFeeds.Size = new System.Drawing.Size(156, 64);
            this.listBoxFeeds.TabIndex = 5;
            this.listBoxFeeds.SelectedIndexChanged += new System.EventHandler(this.listBoxFeeds_SelectedIndexChanged);
            // 
            // listBoxPods
            // 
            this.listBoxPods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPods.FormattingEnabled = true;
            this.listBoxPods.ItemHeight = 12;
            this.listBoxPods.Location = new System.Drawing.Point(0, 0);
            this.listBoxPods.Name = "listBoxPods";
            this.listBoxPods.Size = new System.Drawing.Size(156, 208);
            this.listBoxPods.TabIndex = 4;
            this.listBoxPods.SelectedIndexChanged += new System.EventHandler(this.listBoxPods_SelectedIndexChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(174, 114);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(100, 30);
            this.buttonDownload.TabIndex = 13;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Visible = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPlay.Location = new System.Drawing.Point(174, 48);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 60);
            this.buttonPlay.TabIndex = 12;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // axWindowsMediaPlayerMain
            // 
            this.axWindowsMediaPlayerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayerMain.Enabled = true;
            this.axWindowsMediaPlayerMain.Location = new System.Drawing.Point(280, 12);
            this.axWindowsMediaPlayerMain.Name = "axWindowsMediaPlayerMain";
            this.axWindowsMediaPlayerMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMain.OcxState")));
            this.axWindowsMediaPlayerMain.Size = new System.Drawing.Size(284, 291);
            this.axWindowsMediaPlayerMain.TabIndex = 19;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage,
            this.toolStripProgressBarMain});
            this.statusStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripMain.Location = new System.Drawing.Point(0, 306);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(576, 22);
            this.statusStripMain.TabIndex = 20;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelMessage.Text = "Ready.";
            // 
            // toolStripProgressBarMain
            // 
            this.toolStripProgressBarMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            this.toolStripProgressBarMain.RightToLeftLayout = true;
            this.toolStripProgressBarMain.Size = new System.Drawing.Size(100, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 328);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.axWindowsMediaPlayerMain);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxDebug);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonPlay);
            this.Name = "FormMain";
            this.Text = "PodZooc 0.2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMain)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListBox listBoxFeeds;
        private System.Windows.Forms.ListBox listBoxPods;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarMain;
    }
}

