using System;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca.Databases;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir um novo cliente na base de dados";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Atualizar o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpar dados da tela";
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }
        
        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.unit c = new Cliente.unit();
                c = LeituraFormulario();
                c.Id = Txt_Codigo.Text;
                c.ValidaClasse();
                c.ValidaComponente();
                string clienteJson = Cliente.SerializedClassUnit(c);

                Fichario F = new Fichario("C:\\Users\\Kleber\\Source\\Repos\\KleberLuccas\\WindowsForms\\Fichario");
                if (F.status == true)
                {
                    F.Incluir(c.Id, clienteJson);
                    if(F.status)
                    {
                        MessageBox.Show("OK " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Cliente será incluído. O conteudo será " + clienteJson, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Cliente.unit LeituraFormulario()
        {
            Cliente.unit C = new Cliente.unit();
            C.Id = Txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeDaMae = Txt_NomeMae.Text;
            C.NomeDoPai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                C.TemPai = true;
            }
            else
            {
                C.TemPai = false;
            }

            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Outros.Checked)
            {
                C.Genero = 2;
            }
            C.CPF = Txt_CPF.Text;

            C.CEP = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;
            
            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = null;
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            C.telefone = Txt_Telefone.Text;
            C.profissao = Txt_Profissao.Text;
            
            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if (vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }

            return C;
        }

        public void EscreverFormulario(Cliente.unit C)
        {
            Txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeDaMae;
            Txt_NomePai.Text = C.NomeDoPai;
            if (C.TemPai == true)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Chk_TemPai.Checked = false;
                Txt_NomePai.Text = C.NomeDoPai;
            }

            if (C.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            if (C.Genero == 2)
            {
                Rdb_Outros.Checked = true;
            }
            Txt_CPF.Text = C.CPF;

            Txt_CEP.Text = C.CEP;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;
            Txt_Telefone.Text = C.telefone;
            Txt_Profissao.Text = C.profissao;

            if (C.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }
            Txt_RendaFamiliar.Text = C.RendaFamiliar.ToString();
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {

            string vCEP = Txt_CEP.Text;

            if (vCEP != "")
            {
                if (vCEP.Length == 8)
                {
                    if (Information.IsNumeric(vCEP))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCEP);

                        CEP.unit Cep = new CEP.unit();
                        Cep = CEP.DesSerializedClassUnit(vJson);
                        Txt_Bairro.Text = Cep.bairro;
                        Txt_Logradouro.Text = Cep.logradouro;
                        Txt_Cidade.Text = Cep.localidade;

                        Cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + Cep.uf + ")" );

                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_CPF.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_Cidade.Text = "";
            Txt_Bairro.Text = "";
            Txt_Codigo.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = "";
            Txt_Telefone.Text = "";
            Cmb_Estados.SelectedIndex = -1;

            Chk_TemPai.Checked = false;
            Rdb_Masculino.Checked = true;
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Codigo do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\Users\\Kleber\\Source\\Repos\\KleberLuccas\\WindowsForms\\Fichario"); 
                if (F.status)
                {
                    string clienteJson = F.Buscar(Txt_Codigo.Text);
                    Cliente.unit C = new Cliente.unit();
                    C = Cliente.DesSerializedClassUnit(clienteJson);
                    EscreverFormulario(C);
                }
                else
                {
                    MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelartoolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Codigo do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\Users\\Kleber\\Source\\Repos\\KleberLuccas\\WindowsForms\\Fichario");
                if (F.status)
                {
                    string clienteJson = F.Apagar(Txt_Codigo.Text);
                    Cliente.unit C = new Cliente.unit();
                    C = Cliente.DesSerializedClassUnit(clienteJson);
                    EscreverFormulario(C);
                }
                else
                {
                    MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
