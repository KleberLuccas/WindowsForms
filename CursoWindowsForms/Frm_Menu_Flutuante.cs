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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //var posicaoX = e.X;
                //var posicaoY = e.Y;
                //MessageBox.Show("Botão direito clicado. A posição relativa foi (" + posicaoX.ToString() + "," + posicaoY.ToString() + ")");
                
                var contextMenu =  
            }
        }
    }
}
