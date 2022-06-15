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

                //MessageBox.Show("O botão clicado foi o da direita. A posição relativa é (" + posicaoX.ToString() + "," + posicaoY.ToString() + ")");
                //Instanciando menu 
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item Menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item Menu 2", "Frm_ValidaSenha");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                //Adicionando o item do menu ao menu, chamando a função e atribuindo texto
                //ContextMenu.Items.Add(DesenhaItemMenu("Item Menu 1", "key"));
                //ContextMenu.Items.Add(DesenhaItemMenu("Item Menu 2", "Frm_ValidaSenha"));
                //Exibindo o menu na tela.
                //Parâmetros: Próprio formulario, posição para exibir menu
                ContextMenu.Show(this, new Point(e.X, e.Y));

                //Instanciando os métodos de clique à função de click.
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                //Instanciando item do menu
                var vToolTip = new ToolStripMenuItem();
                //Atribuindo um texto ao item do menu
                vToolTip.Text = text;
                //Instanciando variavel do tipo 'Imagem' com o nome da imagem.
                Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;

                return vToolTip;
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção 001 do menu");
            }

            void vToolTip002_Click(object sender2, EventArgs e2)
            {
                MessageBox.Show("Selecionei a opção 002 do menu");

            }
        } 


    }
}
