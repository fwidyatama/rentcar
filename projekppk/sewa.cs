using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekppk
{

    public partial class Sewa : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection connection;
        public Sewa()
        {
            InitializeComponent();
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void sewa_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsewamobil_Click(object sender, EventArgs e)
        {
            if (tbMerk.Text != "" && tbTipe.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text!="" && labelNama.Text!="")
            {
                try
                {
                    string Query = "insert into transaksi(merk,tipe,tanggal_pinjam,tanggal_kembali,nama) values('" + this.tbMerk.Text + "','" + this.tbTipe.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + this.labelNama.Text + "');";
                    MySqlCommand tambah = new MySqlCommand(Query, connection);
                    MySqlDataReader reader;
                    connection.Open();
                    reader = tambah.ExecuteReader();
                    MessageBox.Show("Berhasil menambahkan Transaksi");
                    while (reader.Read())
                    {

                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }

    }
}

