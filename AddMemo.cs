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
using System.Timers;

namespace DigitalReadingSheet
{
    public partial class AddMemo : DevExpress.XtraEditors.XtraForm
    {
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;
        private SQLiteDataReader dataReader;

        private string timeFormat = "yyyy-mm-dd hh:mm:ss";

        private List<int> ids;

        public AddMemo(SQLiteConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            ids = new List<int>();
        }

        private void fillCombo()
        {
            unity.Items.Clear();
            this.cnx.Open();
            try
            {
                this.cmd = new SQLiteCommand("SELECT * FROM unites", this.cnx);
                dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    unity.Items.Add(dataReader.GetString(1));
                    ids.Add(dataReader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }

        private void AddMemo_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {  
            int idUnite = ids[unity.SelectedIndex];
            DateTime time = DateTime.Now.AddDays(Double.Parse(validity.Text));

            string query = "INSERT INTO memos VALUES (null, @IDUNITE, @TITLE, @CONTENT, @TIME)";
            this.cnx.Open();
            try
            {
                this.cmd = new SQLiteCommand(query, this.cnx);
                this.cmd.Parameters.Add(new SQLiteParameter("@IDUNITE", idUnite));
                this.cmd.Parameters.Add(new SQLiteParameter("@TITLE", title.Text));
                this.cmd.Parameters.Add(new SQLiteParameter("@CONTENT", content.Text));
                this.cmd.Parameters.Add(new SQLiteParameter("@TIME", time.ToString(timeFormat)));

                int i = this.cmd.ExecuteNonQuery();
                if(i == 1)
                {
                    MessageBox.Show("Insertion effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {

        }
    }
}