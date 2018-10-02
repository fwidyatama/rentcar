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
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projectppk; SslMode=none; Convert Zero Datetime=True;";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            string query = "select * from transaksi";
            //int,merk,tipe,tanggal_pinjam,tanggal_kembali,nama
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            materialListView1.View = View.Details;
            materialListView1.Columns.Add("NO");
            materialListView1.Columns.Add("MERK");
            materialListView1.Columns.Add("TIPE");
            materialListView1.Columns.Add("TANGGAL PINJAM");
            materialListView1.Columns.Add("TANGGAL KEMBALI");
            materialListView1.Columns.Add("NAMA");


            while (reader.Read())
            {
                var item = new ListViewItem();
                DateTime parseDatepinjam = DateTime.Parse(reader["tanggal_pinjam"].ToString());
                DateTime parseDatekembali = DateTime.Parse(reader["tanggal_kembali"].ToString());

                item.Text = reader["int"].ToString();
                item.SubItems.Add(reader["merk"].ToString());
                item.SubItems.Add(reader["tipe"].ToString());
                item.SubItems.Add(parseDatepinjam.ToString("d"));
                item.SubItems.Add(parseDatekembali.ToString("d"));

                
               
                item.SubItems.Add(reader["nama"].ToString());
                materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                materialListView1.Items.Add(item);

            }

            reader.Close();


        }
    }
}
