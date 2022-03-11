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
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void Btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            string Str1 = e.Button.ToString();
            MessageBox.Show("Foi pressionado o botão da(o) " + Str1);
        }
    }
}
