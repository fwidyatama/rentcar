using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekppk
{

    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    
    {
        MySqlConnection connection;
        public Form1()
        {
           
            InitializeComponent();
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Pink400, MaterialSkin.TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            String username = labelinputusername.Text;
            String password = labelinputpassword.Text;
           
            try
            {
                connection.Open();
                MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM user WHERE username = '"+username+"' && password='"+password +"'", connection);
                DataTable datatabel = new DataTable();
                data.Fill(datatabel);
                if (datatabel.Rows.Count >0)
                {
                    home page = new home();
                   
                    page.Show();
                   this.Hide();

                }
                else
                {
                    MessageBox.Show("gagal");
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
