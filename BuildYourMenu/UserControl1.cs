using BuildYourMenu.Business.Abstract;
using BuildYourMenu.Business.DependencyResolvers.Ninject;
using BuildYourMenu.DataAccess.Concrete.EntityFramework;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildYourMenu.WebFormsUI
{
    public partial class UserControl1 : Form
    {
        public UserControl1()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

        }

        private IUserService _userService;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            _userService.Add(new User
            {
                UserName = tbxUsernameRegister.Text,
                UserPass = tbxPassRegister.Text,
                UserMail = tbxEmailRegister.Text,
            });
            MessageBox.Show("Kaydınız Başarıyla Tamamlandı.");
            GetUsers();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void GetUsers()
        {
            cbxUsers.DataSource = _userService.GetAll();
            cbxUsers.DisplayMember = "UserName";
            cbxUsers.ValueMember = "UserId";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userService.Get(cbxUsers.Text, tbxPassLogin.Text) != null)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else if (_userService.Get(cbxUsers.Text, tbxPassLogin.Text) == null)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "WARNİNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserControl1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
