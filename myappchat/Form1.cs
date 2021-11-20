using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myappchat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string DbUserIdServer, DbPasswdServer, DbDataSourceServer;
            koneksi_DB1 kon = new koneksi_DB1();
            DbUserIdServer = kon.cetak_DbUserIdServer();
            DbPasswdServer = kon.cetak_DbPasswdServer();
            DbDataSourceServer = kon.cetak_DbDataSourceServer();
            label1.Text = DbUserIdServer;
            label2.Text = DbPasswdServer;
            label3.Text = DbDataSourceServer;
            ShowData();
        }


        private void ShowData()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=" + label1.Text + ";Password=" + label2.Text + ";Data Source = '" + label3.Text + "';"))
                using (OracleCommand cmd = new OracleCommand("select * from TBLCHAT",conn))
                {
                    conn.Open();
                    using(OracleDataReader reader = cmd.ExecuteReader()){
                        while(reader.Read())
                        {
                            listchat.Items.Add(reader["NAMA"].ToString()+" : "+reader["MESSAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Koneksi server tidak terhubung");
            }
        }


        public void clear()
        {
            txtidsiswa.Clear();
            txtmessage.Clear();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            txtnama.Enabled = true;
            txtidsiswa.Enabled = true;
            btnok.Visible = true;
            txtmessage.Enabled = false;
            btnadduser.Visible = false;
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            listchat.Items.Clear();
            txtnama.Enabled = false;
            txtidsiswa.Enabled = false;
            btnok.Visible = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtidsiswa.Text != "" && txtnama.Text != "")
            {
                koneksi_DB2 smscon = new koneksi_DB2();
                if (smscon.query_db("insert into TBLCHAT values('" + this.txtidsiswa.Text + "','" + this.txtnama.Text + "','" + " Ready" + "')") != 0)
                {
                    btnreload_Click(sender, e);
                    DialogResult dialogResult = MessageBox.Show("User Terhubung");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("User tidak Terhubung");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("inputan tidak lengkap");
            }

            txtmessage.Enabled = true;
            txtnama.Enabled = false;
            txtidsiswa.Enabled = false;
            btnok.Visible = false;
            btnadduser.Visible = true;
            txtinputid.Text = txtidsiswa.Text;
            lblnamauser.Text = txtnama.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listchat.Items.Clear();
            ShowData();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            txtnama.Enabled = false;
            txtidsiswa.Enabled = false;
            btnok.Visible = false;
            btnadduser.Visible = true;

            if (txtinputid.Text != "" && txtmessage.Text != "")
            {
                koneksi_DB2 smskon = new koneksi_DB2();
                if (smskon.query_db("insert into tblchat values('" + this.txtinputid.Text + "','" + this.lblnamauser.Text + "','" + this.txtmessage.Text + "')") != 0)
                {
                    btnreload_Click(sender, e);
                    ShowData();
                    txtmessage.Clear();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Pesan gagal diirim !");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("inputan tidak lengkap !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi_DB2 trun = new koneksi_DB2();
            trun.query_db("delete from tblchat");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection("User Id="+label1+";Password ="+label2.Text+";Data Source='"+label3.Text+"';"))
                using (OracleCommand cmd = new OracleCommand("select * from tblchat where ID_CHAT = '" + txtinputid.Text + "'", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblnamauser.Text = reader["NAMA"].ToString();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtinputid_MouseClick(object sender, MouseEventArgs e)
        {
            txtinputid.Clear();
        }
    }
}
