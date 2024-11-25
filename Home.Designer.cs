namespace DigitalReadingSheet
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.is_startup_app = new System.Windows.Forms.CheckBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afficherMiniMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherCacherLesMémosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.about_btn = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.setting_btn = new System.Windows.Forms.Button();
            this.unit_management_btn = new System.Windows.Forms.Button();
            this.reminder_btn = new System.Windows.Forms.Button();
            this.add_memo_btn = new System.Windows.Forms.Button();
            this.notifyIconContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // is_startup_app
            // 
            this.is_startup_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.is_startup_app.AutoSize = true;
            this.is_startup_app.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.is_startup_app.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.is_startup_app.Location = new System.Drawing.Point(12, 245);
            this.is_startup_app.Name = "is_startup_app";
            this.is_startup_app.Size = new System.Drawing.Size(148, 21);
            this.is_startup_app.TabIndex = 4;
            this.is_startup_app.Text = "Ouvrir au démarrage";
            this.is_startup_app.UseVisualStyleBackColor = true;
            this.is_startup_app.CheckedChanged += new System.EventHandler(this.is_startup_app_CheckedChanged);
            this.is_startup_app.Click += new System.EventHandler(this.is_startup_app_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("MS Outlook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_close.Location = new System.Drawing.Point(364, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.toolTipController1.SetTitle(this.btn_close, "Cacher Mini Memo");
            this.toolTipController1.SetToolTipIconType(this.btn_close, DevExpress.Utils.ToolTipIconType.Information);
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "A";
            this.notifyIcon1.BalloonTipTitle = "A";
            this.notifyIcon1.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mini Memo";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherMiniMemoToolStripMenuItem,
            this.afficherCacherLesMémosToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(219, 70);
            // 
            // afficherMiniMemoToolStripMenuItem
            // 
            this.afficherMiniMemoToolStripMenuItem.Name = "afficherMiniMemoToolStripMenuItem";
            this.afficherMiniMemoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.afficherMiniMemoToolStripMenuItem.Text = "Afficher/Cacher l\'appli";
            this.afficherMiniMemoToolStripMenuItem.Click += new System.EventHandler(this.afficherMiniMemoToolStripMenuItem_Click);
            // 
            // afficherCacherLesMémosToolStripMenuItem
            // 
            this.afficherCacherLesMémosToolStripMenuItem.Name = "afficherCacherLesMémosToolStripMenuItem";
            this.afficherCacherLesMémosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.afficherCacherLesMémosToolStripMenuItem.Text = "Afficher/Cacher les mémos";
            this.afficherCacherLesMémosToolStripMenuItem.Click += new System.EventHandler(this.afficherCacherLesMémosToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // about_btn
            // 
            this.about_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.about_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.about_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.about_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.about_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.about_btn.Font = new System.Drawing.Font("MS Outlook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.about_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.about_btn.Location = new System.Drawing.Point(364, 49);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(50, 50);
            this.about_btn.TabIndex = 6;
            this.about_btn.Text = "X";
            this.toolTipController1.SetTitle(this.about_btn, "A propos de Mini Memo");
            this.toolTipController1.SetToolTipIconType(this.about_btn, DevExpress.Utils.ToolTipIconType.Information);
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(357, 49);
            this.labelControl1.StyleController = this.styleController1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = " Mini Memo v1.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.Transparent;
            this.setting_btn.FlatAppearance.BorderSize = 0;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setting_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.setting_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.setting_btn.Image = global::DigitalReadingSheet.Properties.Resources.settings_blue_32;
            this.setting_btn.Location = new System.Drawing.Point(188, 161);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(170, 68);
            this.setting_btn.TabIndex = 3;
            this.setting_btn.Text = "Paramètrage";
            this.setting_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // unit_management_btn
            // 
            this.unit_management_btn.BackColor = System.Drawing.Color.Transparent;
            this.unit_management_btn.FlatAppearance.BorderSize = 0;
            this.unit_management_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unit_management_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.unit_management_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.unit_management_btn.Image = global::DigitalReadingSheet.Properties.Resources.grid_2_32;
            this.unit_management_btn.Location = new System.Drawing.Point(12, 161);
            this.unit_management_btn.Name = "unit_management_btn";
            this.unit_management_btn.Size = new System.Drawing.Size(170, 68);
            this.unit_management_btn.TabIndex = 2;
            this.unit_management_btn.Text = "Gestion des unités";
            this.unit_management_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unit_management_btn.UseVisualStyleBackColor = false;
            this.unit_management_btn.Click += new System.EventHandler(this.unit_management_btn_Click);
            // 
            // reminder_btn
            // 
            this.reminder_btn.BackColor = System.Drawing.Color.Transparent;
            this.reminder_btn.FlatAppearance.BorderSize = 0;
            this.reminder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reminder_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.reminder_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reminder_btn.Image = global::DigitalReadingSheet.Properties.Resources.alarm_blue_32;
            this.reminder_btn.Location = new System.Drawing.Point(188, 78);
            this.reminder_btn.Name = "reminder_btn";
            this.reminder_btn.Size = new System.Drawing.Size(170, 68);
            this.reminder_btn.TabIndex = 1;
            this.reminder_btn.Text = "Rappel";
            this.reminder_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reminder_btn.UseVisualStyleBackColor = false;
            this.reminder_btn.Click += new System.EventHandler(this.reminder_btn_Click);
            // 
            // add_memo_btn
            // 
            this.add_memo_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_memo_btn.FlatAppearance.BorderSize = 0;
            this.add_memo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_memo_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.add_memo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_memo_btn.Image = global::DigitalReadingSheet.Properties.Resources.create_32;
            this.add_memo_btn.Location = new System.Drawing.Point(12, 78);
            this.add_memo_btn.Name = "add_memo_btn";
            this.add_memo_btn.Size = new System.Drawing.Size(170, 68);
            this.add_memo_btn.TabIndex = 0;
            this.add_memo_btn.Text = "Ajouter des mémos";
            this.add_memo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_memo_btn.UseVisualStyleBackColor = false;
            this.add_memo_btn.Click += new System.EventHandler(this.add_memo_btn_Click);
            // 
            // Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 278);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.unit_management_btn);
            this.Controls.Add(this.reminder_btn);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.add_memo_btn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.is_startup_app);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Memo V1.0";
            this.Load += new System.EventHandler(this.Home_Load);
            this.notifyIconContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox is_startup_app;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem afficherMiniMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.StyleController styleController1;
        private System.Windows.Forms.Button add_memo_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Button reminder_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button unit_management_btn;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem afficherCacherLesMémosToolStripMenuItem;

    }
}

