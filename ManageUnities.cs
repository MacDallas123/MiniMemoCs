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
    public partial class ManageUnities : DevExpress.XtraEditors.XtraForm
    {
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;
        private SQLiteDataReader dataReader;
        private List<int> ids;
        private List<String> dates, memos_titles;

        public ManageUnities(SQLiteConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            ids = new List<int>();
            dates = new List<String>();
            memos_titles = new List<string>();
        }

        private void fillCombo()
        {
            get_label.Items.Clear();
            ids.Clear();
            dates.Clear();
            this.cnx.Open();
            try
            {
                this.cmd = new SQLiteCommand("SELECT * FROM unites", this.cnx);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    get_label.Items.Add(dataReader.GetString(1));
                    ids.Add(dataReader.GetInt32(0));
                    dates.Add(dataReader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }

        private void getInfos()
        {
            this.cnx.Open();
            int i = ids[get_label.SelectedIndex];
            memos_titles.Clear();
            try
            {
                this.cmd = new SQLiteCommand("SELECT * FROM memos WHERE idUnite=" + i + ";", this.cnx);
                dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    memos_titles.Add(dataReader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }

        private void ManageUnities_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.cnx.Open();
            try
            {
                string query = "INSERT INTO unites VALUES (null, @LABEL, @ACTIVATION)";
                this.cmd = new SQLiteCommand(query, this.cnx);
                this.cmd.Parameters.Add(new SQLiteParameter("@LABEL", new_label.Text));
                this.cmd.Parameters.Add(new SQLiteParameter("@ACTIVATION", new_activation.Value));
                if (this.cmd.ExecuteNonQuery() == 1) MessageBox.Show("L'insertion s'est bien effectuée", "Opération reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();

            fillCombo();
            new_label.Focus();
        }

        private void get_label_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                get_activation.Value = DateTime.Parse(dates[get_label.SelectedIndex]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Date Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void infos_btn_Click(object sender, EventArgs e)
        {
            try
            {
                getInfos();
                string txt = "Les mémos associées à cette unitée sont les suivantes : \n";
                for (int i = 0; i < memos_titles.Count; i++)
                {
                    txt += memos_titles[i] + "\n";
                }

                MessageBox.Show(txt, "Infos sur l'unité", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string message = "Etes-vous sur de vouloir supprimer cette unité, les memos associées seront également effacées";
            if(MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.cnx.Open();
                try
                {
                    int i = ids[get_label.SelectedIndex];
                    string query = "DELETE FROM unites WHERE id = @ID";
                    this.cmd = new SQLiteCommand(query, this.cnx);
                    this.cmd.Parameters.Add(new SQLiteParameter("@ID", i));
                    if (this.cmd.ExecuteNonQuery() == 1) MessageBox.Show("La suppression s'est bien effectuée", "Opération reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Db Suppression Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.cnx.Close();

                fillCombo();
            }          
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.cnx.Open();
            try
            {
                int i = ids[get_label.SelectedIndex];
                string query = "UPDATE unites SET date = @ACTIVATION WHERE id = @ID";
                this.cmd = new SQLiteCommand(query, this.cnx);
                this.cmd.Parameters.Add(new SQLiteParameter("@ID", i));
                this.cmd.Parameters.Add(new SQLiteParameter("@ACTIVATION", get_activation.Value));
                if (this.cmd.ExecuteNonQuery() == 1) MessageBox.Show("La modification s'est bien effectuée", "Opération reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Suppression Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cnx.Close();

            fillCombo();
        }
    }
}