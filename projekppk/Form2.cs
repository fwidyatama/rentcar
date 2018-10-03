using System;
using System.IO;
using System.Data;
using System.Configuration;
using System.Linq;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekppk
{
    public partial class Order : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection connection;
        public Order()
        {
            InitializeComponent();
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=bumiasri; database=projectppk; SslMode=none; Convert Zero Datetime=True;";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            string query = "select t.id, t.tanggal_pinjam, t.tanggal_kembali, t.nama, t.no_telpon, m.merk, m.tipe, m.plat_nomor, DATEDIFF(t.tanggal_kembali, t.tanggal_pinjam) * m.harga as biaya from transaksi t join mobil m on t.id_mobil = m.id";
            //int,merk,tipe,tanggal_pinjam,tanggal_kembali,nama
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            RiwayatOrder.View = View.Details;
            RiwayatOrder.Columns.Add("NO");
            RiwayatOrder.Columns.Add("MERK");
            RiwayatOrder.Columns.Add("TIPE");
            RiwayatOrder.Columns.Add("NO POLISI");
            RiwayatOrder.Columns.Add("NAMA");
            RiwayatOrder.Columns.Add("NO TELEPON");
            RiwayatOrder.Columns.Add("TANGGAL PINJAM");
            RiwayatOrder.Columns.Add("TANGGAL KEMBALI");
            RiwayatOrder.Columns.Add("BIAYA");


            while (reader.Read())
            {
                var item = new ListViewItem();
                DateTime parseDatepinjam = DateTime.Parse(reader["tanggal_pinjam"].ToString());
                DateTime parseDatekembali = DateTime.Parse(reader["tanggal_kembali"].ToString());

                item.Text = reader["id"].ToString();
                item.SubItems.Add(reader["merk"].ToString());
                item.SubItems.Add(reader["tipe"].ToString());
                item.SubItems.Add(reader["plat_nomor"].ToString());
                item.SubItems.Add(reader["nama"].ToString());
                item.SubItems.Add(reader["no_telpon"].ToString());
                item.SubItems.Add(parseDatepinjam.ToString("d"));
                item.SubItems.Add(parseDatekembali.ToString("d"));
                item.SubItems.Add(reader["biaya"].ToString());



                item.SubItems.Add(reader["nama"].ToString());
                RiwayatOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                RiwayatOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                RiwayatOrder.Items.Add(item);

            }

            reader.Close();


        }
    }
}
