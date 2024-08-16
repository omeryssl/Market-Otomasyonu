using DevExpress.XtraWaitForm;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities.Concreate;
using MarketDatabse.Business.LoginDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDatabase.FormUI.Displays
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        LoginManager manager = new LoginManager(new UserFailDal());
        private void button1_Click(object sender, EventArgs e)
        {
           
          

            var user = manager.GetUser(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                Global.LoggedInUsername = user.Name;
                HomePagee mainForm = new HomePagee();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");
            }
        }

        private void kullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
