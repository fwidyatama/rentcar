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
    public partial class TambahMobil : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection connection;
        public TambahMobil()
        {
            InitializeComponent();
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void tambahmobil_Load(object sender, EventArgs e)
        {

        }

        private void btnsewamobil_Click(object sender, EventArgs e)
        {
            Convert.ToInt64(this.materialSingleLineTextField1.Text);
            if (tbMerk.Text != "" && tbTipe.Text != "" && materialSingleLineTextField1.Text != "" && materialSingleLineTextField2.Text != "")
            {
                try
                {
                    string Query = "insert into mobil(merk,tipe,harga,plat_nomor) values('" + this.tbMerk.Text + "','" + this.tbTipe.Text + "','" + Convert.ToInt64(this.materialSingleLineTextField1.Text) + "','" + Convert.ToInt64(this.materialSingleLineTextField2.Text)+ "')";
                    MySqlCommand tambah = new MySqlCommand(Query, connection);
                    MySqlDataReader reader;
                    connection.Open();
                    reader = tambah.ExecuteReader();
                    MessageBox.Show("Berhasil menambahkan jenis mobil");
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

