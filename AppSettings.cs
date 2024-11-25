using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using DigitalReadingSheet.Properties;

namespace DigitalReadingSheet
{
    public partial class AppSettings : DevExpress.XtraEditors.XtraForm
    {
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;
        private SQLiteDataReader dataReader;

        private Settings settings;

        public AppSettings(SQLiteConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            settings = new Settings();
        }

        private void loadMemos()
        {

        }

        private void loadReminders()
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            frequency.Text = settings.frequency.ToString();
            sound.Text = settings.soundPath;
            design.Text = settings.design.ToString();
            design.SelectedIndex = settings.design;
            set_randomly.Checked = settings.randomly;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            loadMemos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadReminders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.Filter = "Fichiers audio (*.wav)|*.wav";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                sound.Text = fileDialog.FileName;
                settings.soundPath = fileDialog.FileName;
            }
            settings.Save();
        }

        private void frequency_Leave(object sender, EventArgs e)
        {
            try
            {
                settings.frequency = int.Parse(frequency.Text);
                settings.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Valeur non numérique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void design_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.design = design.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (set_randomly.Checked) settings.randomly = true;
            else settings.randomly = false;

            settings.Save();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redémarrer Mini Memo pour que les changements prennent effet.", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}