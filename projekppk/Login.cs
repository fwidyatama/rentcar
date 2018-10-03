using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekppk
{

    public partial class Login : MaterialSkin.Controls.MaterialForm
    
    {
        MySqlConnection connection;
        

        public Login()
        {
            CenterToScreen();
            InitializeComponent();                     
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Primary.Pink500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            String connectionInfo = "datasource=localhost; port=3306; username=root; password=bumiasri; database=projectppk; SslMode=none";
            connection = new MySqlConnection(connectionInfo);                        
        }

        private void checkboxRemember_Change(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = inputUsername.Text;
            String password = inputPassword.Text;
            try
            {
                connection.Open();
                MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM user WHERE username = '" + username + "' && password='" + password + "'", connection);
                DataTable datatabel = new DataTable();
                data.Fill(datatabel);
                if (datatabel.Rows.Count > 0)
                {
                    home page = new home();
                    page.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
