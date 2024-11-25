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
using DigitalReadingSheet.Properties;
using System.Data.SQLite;
using System.Media;

namespace DigitalReadingSheet
{
    public partial class NoticeForm : DevExpress.XtraEditors.XtraForm
    {
        private int counter = 0;
        private Settings settings;
        private SQLiteConnection cnx;
        private SQLiteCommand cmd;
        private SQLiteDataReader dataReader;

        private List<string> memos_titles;
        private List<string> memos_contents;

        private string reminder_desc;

        private SoundPlayer soundPlayer;

        private int idx = 0;
        private Random r;

        public NoticeForm()
        {
            InitializeComponent();
            timer1.Start();
            settings = new Settings();
            memos_titles = new List<string>();
            memos_contents = new List<string>();
            r = new Random();
        }

        private void loadDatas()
        {
            memos_titles.Clear();
            memos_contents.Clear();
            this.cnx.Open();
            try
            {
                //Chargement des mémos associées aux unités actives
                this.cmd = new SQLiteCommand("SELECT * FROM memos WHERE idUnite IN (SELECT id FROM unites WHERE date < @DATE)", this.cnx);
                this.cmd.Parameters.Add(new SQLiteParameter("@DATE", DateTime.Now));
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    memos_titles.Add(dataReader.GetString(2));
                    memos_contents.Add(dataReader.GetString(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }

        private void getReminders()
        {
            reminder_desc = "";
            this.cnx.Open();
            try
            {
                //Chargement des mémos associées aux unités actives
                this.cmd = new SQLiteCommand("SELECT * FROM rappels WHERE date == julianday('now')", this.cnx);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    reminder_desc = dataReader.GetString(1);
                }

                if(reminder_desc != "")
                {
                    soundPlayer = new SoundPlayer(@settings.soundPath);
                    soundPlayer.PlayLooping();
                    if(MessageBox.Show(reminder_desc, "Rappel activé", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        soundPlayer.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Db Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }

        private void changeContent()
        {
            title_inf.Text = memos_titles[idx];
            content_inf.Text = memos_contents[idx];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (counter > settings.frequency)
                {
                    counter = 0;
                    loadDatas();
                    if(settings.randomly)
                    {
                        idx = r.Next(memos_titles.Count);
                    }               
                    else
                    {
                        idx++;
                        idx = idx % memos_titles.Count;
                    }
                    changeContent();
                }
                counter++;

                getReminders();

                test.Text = "idx : " + idx + "; lenght : " + memos_titles.Count + "; counter : " + counter + "; frequency : " + settings.frequency;
                
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Db Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoticeForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.cnx = new SQLiteConnection("Data Source=" + settings.dbName + ";version=3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                loadDatas();
                if (settings.randomly)
                    idx = r.Next(memos_titles.Count);
                else
                {
                    idx++;
                    idx = idx % memos_titles.Count;
                }
                changeContent();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void NoticeForm_MouseHover(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
        }

        private void NoticeForm_MouseLeave(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

    }
}