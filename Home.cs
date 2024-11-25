using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using DigitalReadingSheet.Properties;
using System.Data.SQLite;
using System.IO;
using System.Media;
using System.Resources;

namespace DigitalReadingSheet
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        private Settings setting;
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;
        private NoticeForm nf;

        private string timeFormat = "yyyy-MM-dd hh:mm:ss";

        public Home()
        {
            InitializeComponent();
            setting = new Settings();
            timer1.Start();
        }

        private void updateMemos()
        {
            this.cnx.Open();
            try
            {
                string query = "DELETE FROM memos WHERE validite < julianday('now')";
                this.cmd = new SQLiteCommand(query, this.cnx);
                if (this.cmd.ExecuteNonQuery() >= 1) MessageBox.Show("Certaines de vos mémos ont expirées aujourd'hui, pensez à sauvegarder d'autres mémos", "Mise à jour des mémos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Memos update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();
        }

        private void updateReminders()
        {
            this.cnx.Open();
            try
            {
                string query = "DELETE FROM rappels WHERE date < julianday('now');";
                this.cmd = new SQLiteCommand(query, this.cnx);
                if (this.cmd.ExecuteNonQuery() >= 1) MessageBox.Show("Certaines de vos rappels ont expirées aujourd'hui.", "Mise à jour des rappels", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reminders update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            is_startup_app.Checked = setting.startup;
            
            try
            {
                if(!File.Exists(setting.dbName))
                {
                    SQLiteConnection.CreateFile(setting.dbName);
                }

                this.cnx = new SQLiteConnection("Data Source=" + setting.dbName + ";version=3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            createDbTables();
            updateMemos();
            updateReminders();

            if (setting.soundPath == null)
            {
                setting.soundPath = "Resources/ring.wav";
            }

            NoticeForm nf = new NoticeForm();
            this.nf = nf;
            nf.Show();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            nf.Location = new Point(w - nf.Width - 10, h - nf.Height - 45);
        }

        private void createDbTables()
        {
            string query = "CREATE TABLE IF NOT EXISTS unites (id INTEGER PRIMARY KEY AUTOINCREMENT, libelle TEXT, date DATETIME);";
            string query2 = "CREATE TABLE IF NOT EXISTS memos (id INTEGER PRIMARY KEY AUTOINCREMENT,idUnite INTEGER REFERENCES unites ON DELETE CASCADE, titre TEXT, contenu TEXT, validite DATETIME);";
            string query3 = "CREATE TABLE IF NOT EXISTS rappels (id INTEGER PRIMARY KEY AUTOINCREMENT, description TEXT, date DATETIME);";

            this.cnx.Open();
            try
            {
                this.cmd = new SQLiteCommand(query, this.cnx);
                this.cmd.ExecuteNonQuery();

                this.cmd = new SQLiteCommand(query2, this.cnx);
                this.cmd.ExecuteNonQuery();

                this.cmd = new SQLiteCommand(query3, this.cnx);
                this.cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //notifyIcon1.BalloonTipTitle = "Mini Memo V1";
            //notifyIcon1.BalloonTipText = "L'application foncitonne en arrière plan, faites un clic droit sur l'icône de notification pour quitter l'application.";
            //notifyIcon1.ShowBalloonTip(100000);
            this.Visible = false;
        }

        private void is_startup_app_CheckedChanged(object sender, EventArgs e)
        {
            /*RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if(is_startup_app.Checked)
            {
                rkApp.SetValue("Mini Memo", Application.ExecutablePath.ToString());
                setting.startup = true;
            }
            else
            {
                rkApp.DeleteValue("Mini Memo", false);
                setting.startup = false;
            }*/
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible) this.Visible = false;
            else this.Visible = true;
        }

        private void afficherMiniMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible) this.Visible = false;
            else this.Visible = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_memo_btn_Click(object sender, EventArgs e)
        {
            AddMemo addmemo = new AddMemo(this.cnx);
            addmemo.ShowDialog();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void unit_management_btn_Click(object sender, EventArgs e)
        {
            ManageUnities mu = new ManageUnities(this.cnx);
            mu.ShowDialog();
        }

        private void is_startup_app_Click(object sender, EventArgs e)
        {
            /*RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if(is_startup_app.Checked)
            {
                rkApp.SetValue("Mini Memo", Application.ExecutablePath.ToString());
                setting.startup = true;
            }
            else
            {
                rkApp.DeleteValue("Mini Memo", false);
                setting.startup = false;
            }*/
            string message = "Veuillez cliquer sur <<OK>> pour confirmer l'opération.";
            if (MessageBox.Show(message, "Confirmer l'opération", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                /*if (is_startup_app.Checked)
                    setting.startup = true;
                else
                {

                }
                setting.startup = false;*/
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (is_startup_app.Checked)
                {
                    rkApp.SetValue("Mini Memo", Application.ExecutablePath.ToString());
                    setting.startup = true;
                }
                else
                {
                    rkApp.DeleteValue("Mini Memo", false);
                    setting.startup = false;
                }

            }
            else
            {
                if (is_startup_app.Checked) is_startup_app.Checked = false;
                else is_startup_app.Checked = true;
            }


            setting.Save();
        }

        private void reminder_btn_Click(object sender, EventArgs e)
        {
            ManageReminder mr = new ManageReminder(this.cnx);
            mr.ShowDialog();
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            AppSettings set = new AppSettings(this.cnx);
            set.ShowDialog();
        }

        private void afficherCacherLesMémosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.nf.Visible) this.nf.Visible = false;
            else this.nf.Visible = true;
        }
       
    }
}
