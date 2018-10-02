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
    public partial class home : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection connection;
        public home()
        {
            InitializeComponent();
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void home_Load(object sender, EventArgs e)
        {
            string query = "select id,merk,tipe,harga,plat_nomor from mobil";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            materialListView1.View = View.Details;
            materialListView1.Columns.Add("ID");
            materialListView1.Columns.Add("MERK");
            materialListView1.Columns.Add("TIPE");
            materialListView1.Columns.Add("HARGA");
            materialListView1.Columns.Add("PLAT NOMOR");

            while (reader.Read())
            {
                var item = new ListViewItem();
                
                item.Text = reader["id"].ToString();        
                item.SubItems.Add(reader["merk"].ToString());  
                item.SubItems.Add(reader["tipe"].ToString());
                item.SubItems.Add(reader["harga"].ToString());
                item.SubItems.Add(reader["plat_nomor"].ToString());
                materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                materialListView1.Items.Add(item);

            }

            reader.Close();


        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            Sewa Sewamobil = new Sewa();
            Sewamobil.Show();
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
           TambahMobil tambah = new TambahMobil();
            tambah.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            Order transaksi = new Order();
            transaksi.Show();

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

