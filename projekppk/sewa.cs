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
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=bumiasri; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void sewa_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "select distinct merk from mobil";
                MySqlCommand data = new MySqlCommand(Query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = data.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxMerk.Items.Add(reader["merk"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnsewamobil_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && this.labelNama.Text != "" && this.tbTelpon.Text != "" && (this.comboBoxTersedia.SelectedItem as ComboboxItem).Value.ToString() != "")
           {
                try
                {
                    string Query = "" +
                    "START TRANSACTION;" +
                    "INSERT INTO transaksi(tanggal_pinjam, tanggal_kembali, nama, no_telpon, id_mobil) " +
                    "VALUES('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                            "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") +
                            "','" + this.labelNama.Text +
                            "','" + this.tbTelpon.Text +
                            "','" + (this.comboBoxTersedia.SelectedItem as ComboboxItem).Value.ToString() + "'); " +
                    "UPDATE mobil SET status = 0 WHERE id = '" + (this.comboBoxTersedia.SelectedItem as ComboboxItem).Value.ToString() + "';" + 
                    "COMMIT;";                    
                        
                    MySqlDataReader reader;
                    MySqlCommand tambah = new MySqlCommand(Query, connection);
                    connection.Open();
                    reader = tambah.ExecuteReader();
                    MessageBox.Show("Berhasil menambahkan Transaksi");                    
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

        private void comboBoxMerk_SelectionIndexChange(object sender, EventArgs e)
        {
            try
            {                
                string Query = "" +
                    "select distinct tipe from mobil " +
                    "where merk='" + comboBoxMerk.SelectedItem.ToString() + "'";
                MySqlCommand data = new MySqlCommand(Query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = data.ExecuteReader();
                comboBoxTipe.Items.Clear();
                comboBoxTipe.ResetText();
                comboBoxTersedia.ResetText();
                while (reader.Read())
                {                    
                    comboBoxTipe.Items.Add(reader["tipe"].ToString());
                }                
                connection.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "" +
                    "select id, plat_nomor, harga from mobil " +
                    "where merk='" + comboBoxMerk.SelectedItem.ToString() + "' and " +
                    "tipe='" + comboBoxTipe.SelectedItem.ToString() + "' and status = 1";
                MySqlCommand data = new MySqlCommand(Query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = data.ExecuteReader();
                comboBoxTersedia.Items.Clear();
                comboBoxTersedia.ResetText();
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["plat_nomor"].ToString() + " ---- Rp. " + reader["harga"].ToString();
                    item.Value = reader["id"];
                    comboBoxTersedia.Items.Add(item);                                                     
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

