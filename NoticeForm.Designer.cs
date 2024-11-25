namespace DigitalReadingSheet
{
    partial class NoticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeForm));
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.title_inf = new DevExpress.XtraEditors.LabelControl();
            this.content_inf = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.AllowBorderColorBlending = true;
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Horizontal = false;
            this.splitContainer.Name = "splitContainer";
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.splitContainer_Panel1");
            this.splitContainer.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainer.Panel1.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.splitContainer.Panel1.Controls.Add(this.title_inf);
            this.splitContainer.Panel1.ShowCaption = true;
            this.splitContainer.Panel2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("splitContainerControl1.Panel2.Appearance.BackColor")));
            this.splitContainer.Panel2.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("splitContainerControl1.Panel2.Appearance.BackColor2")));
            this.splitContainer.Panel2.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("splitContainerControl1.Panel2.Appearance.GradientMode")));
            this.splitContainer.Panel2.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.splitContainer_Panel2");
            this.splitContainer.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainer.Panel2.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.splitContainer.Panel2.Controls.Add(this.test);
            this.splitContainer.Panel2.Controls.Add(this.content_inf);
            this.splitContainer.Panel2.Controls.Add(this.btn_close);
            this.splitContainer.Panel2.ShowCaption = true;
            this.splitContainer.SplitterPosition = 77;
            this.splitContainer.MouseLeave += new System.EventHandler(this.NoticeForm_MouseLeave);
            this.splitContainer.MouseHover += new System.EventHandler(this.NoticeForm_MouseHover);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_close.Name = "btn_close";
            this.toolTipController1.SetTitle(this.btn_close, resources.GetString("btn_close.Title"));
            this.toolTipController1.SetToolTipIconType(this.btn_close, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("btn_close.ToolTipIconType"))));
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // title_inf
            // 
            this.title_inf.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.title_inf.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
            resources.ApplyResources(this.title_inf, "title_inf");
            this.title_inf.Name = "title_inf";
            // 
            // content_inf
            // 
            this.content_inf.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.content_inf.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.ForeColor")));
            resources.ApplyResources(this.content_inf, "content_inf");
            this.content_inf.Name = "content_inf";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // test
            // 
            resources.ApplyResources(this.test, "test");
            this.test.Name = "test";
            // 
            // NoticeForm
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("NoticeForm.Appearance.BackColor2")));
            this.Appearance.BorderColor = ((System.Drawing.Color)(resources.GetObject("NoticeForm.Appearance.BorderColor")));
            this.Appearance.Options.UseBorderColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.splitter1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InactiveGlowColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoticeForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NoticeForm_Load);
            this.MouseLeave += new System.EventHandler(this.NoticeForm_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NoticeForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_close;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraEditors.LabelControl title_inf;
        private DevExpress.XtraEditors.LabelControl content_inf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label test;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}