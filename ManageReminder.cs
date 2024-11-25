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

namespace DigitalReadingSheet
{
    public partial class ManageReminder : DevExpress.XtraEditors.XtraForm
    {
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;

        private string timeFormat = "yyyy-MM-dd hh:mm:ss";

        public ManageReminder(SQLiteConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void ManageReminder_Load(object sender, EventArgs e)
        {
            time.EditValue = DateTime.Now;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO rappels VALUES (null, @DESCRIPTION, @DATE)";

            this.cnx.Open();
            try
            {
                this.cmd = new SQLiteCommand(query, this.cnx);
                this.cmd.Parameters.Add(new SQLiteParameter("@DESCRIPTION", description.Text));
                this.cmd.Parameters.Add(new SQLiteParameter("@DATE", time.Time.ToString(timeFormat)));

                int i = this.cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Insertion effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();
        }

        
    }
}