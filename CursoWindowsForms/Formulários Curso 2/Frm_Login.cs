using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Login : Form
    {
        public string Senha;
        public string Login;
        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário";
            Lbl_PassWord.Text = "Senha";
            Btn_Ok.Text = "Ok";
            Btn_Cancel.Text = "Cancel";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Senha = Txt_PassWord.Text;
            Login = Txt_Login.Text;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
