﻿
namespace CursoWindowsForms
{
    partial class Frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Lbl_Telefone;
            System.Windows.Forms.Label Lbl_Profissao;
            System.Windows.Forms.Label Lbl_RendaFamiliar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Txt_RendaFamiliar = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_Código = new System.Windows.Forms.GroupBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdb_Outros = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Grp_TemPai = new System.Windows.Forms.GroupBox();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Grp_OutrosDados = new System.Windows.Forms.GroupBox();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton = new System.Windows.Forms.ToolStripButton();
            Lbl_Telefone = new System.Windows.Forms.Label();
            Lbl_Profissao = new System.Windows.Forms.Label();
            Lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.Grp_Código.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_TemPai.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_OutrosDados.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Telefone
            // 
            Lbl_Telefone.AutoSize = true;
            Lbl_Telefone.Location = new System.Drawing.Point(10, 21);
            Lbl_Telefone.Name = "Lbl_Telefone";
            Lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            Lbl_Telefone.TabIndex = 20;
            Lbl_Telefone.Text = "Telefone";
            // 
            // Lbl_Profissao
            // 
            Lbl_Profissao.AutoSize = true;
            Lbl_Profissao.Location = new System.Drawing.Point(116, 21);
            Lbl_Profissao.Name = "Lbl_Profissao";
            Lbl_Profissao.Size = new System.Drawing.Size(50, 13);
            Lbl_Profissao.TabIndex = 22;
            Lbl_Profissao.Text = "Profissão";
            // 
            // Lbl_RendaFamiliar
            // 
            Lbl_RendaFamiliar.AutoSize = true;
            Lbl_RendaFamiliar.Location = new System.Drawing.Point(516, 21);
            Lbl_RendaFamiliar.Name = "Lbl_RendaFamiliar";
            Lbl_RendaFamiliar.Size = new System.Drawing.Size(77, 13);
            Lbl_RendaFamiliar.TabIndex = 24;
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(6, 134);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CPF.Location = new System.Drawing.Point(6, 150);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(225, 20);
            this.Txt_CPF.TabIndex = 9;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(6, 17);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(85, 13);
            this.Lbl_NomeCliente.TabIndex = 2;
            this.Lbl_NomeCliente.Text = "Nome do Cliente";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(6, 34);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(548, 20);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Location = new System.Drawing.Point(6, 113);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(548, 20);
            this.Txt_NomePai.TabIndex = 7;
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(3, 97);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(68, 13);
            this.Lbl_NomePai.TabIndex = 4;
            this.Lbl_NomePai.Text = "Nome do Pai";
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Location = new System.Drawing.Point(6, 73);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(548, 20);
            this.Txt_NomeMae.TabIndex = 6;
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(6, 57);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(74, 13);
            this.Lbl_NomeMae.TabIndex = 6;
            this.Lbl_NomeMae.Text = "Nome da Mãe";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(9, 33);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(271, 20);
            this.Txt_CEP.TabIndex = 10;
            this.Txt_CEP.Leave += new System.EventHandler(this.Txt_CEP_Leave);
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(9, 17);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(28, 13);
            this.Lbl_CEP.TabIndex = 10;
            this.Lbl_CEP.Text = "CEP";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logradouro.Location = new System.Drawing.Point(9, 73);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(779, 20);
            this.Txt_Logradouro.TabIndex = 13;
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(9, 57);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 12;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(9, 113);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(328, 20);
            this.Txt_Complemento.TabIndex = 14;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(9, 97);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Complemento.TabIndex = 14;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(344, 113);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(311, 20);
            this.Txt_Bairro.TabIndex = 15;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(342, 97);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 16;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(10, 37);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(100, 20);
            this.Txt_Telefone.TabIndex = 16;
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Location = new System.Drawing.Point(118, 37);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(392, 20);
            this.Txt_Profissao.TabIndex = 17;
            // 
            // Txt_RendaFamiliar
            // 
            this.Txt_RendaFamiliar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_RendaFamiliar.Location = new System.Drawing.Point(516, 37);
            this.Txt_RendaFamiliar.Name = "Txt_RendaFamiliar";
            this.Txt_RendaFamiliar.Size = new System.Drawing.Size(269, 20);
            this.Txt_RendaFamiliar.TabIndex = 18;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(6, 19);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(268, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_Código
            // 
            this.Grp_Código.Controls.Add(this.Txt_Codigo);
            this.Grp_Código.Location = new System.Drawing.Point(15, 33);
            this.Grp_Código.Name = "Grp_Código";
            this.Grp_Código.Size = new System.Drawing.Size(281, 49);
            this.Grp_Código.TabIndex = 28;
            this.Grp_Código.TabStop = false;
            this.Grp_Código.Text = "Código";
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_CPF);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(15, 88);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(791, 174);
            this.Grp_DadosPessoais.TabIndex = 29;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Controls.Add(this.Rdb_Outros);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Location = new System.Drawing.Point(583, 17);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(118, 71);
            this.Grp_Genero.TabIndex = 34;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "Genero";
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(4, 12);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(73, 17);
            this.Rdb_Masculino.TabIndex = 3;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "Masculino";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Outros
            // 
            this.Rdb_Outros.AutoSize = true;
            this.Rdb_Outros.Location = new System.Drawing.Point(4, 49);
            this.Rdb_Outros.Name = "Rdb_Outros";
            this.Rdb_Outros.Size = new System.Drawing.Size(56, 17);
            this.Rdb_Outros.TabIndex = 5;
            this.Rdb_Outros.TabStop = true;
            this.Rdb_Outros.Text = "Outros";
            this.Rdb_Outros.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(4, 31);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(67, 17);
            this.Rdb_Feminino.TabIndex = 4;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "Feminino";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Grp_TemPai
            // 
            this.Grp_TemPai.Controls.Add(this.Chk_TemPai);
            this.Grp_TemPai.Location = new System.Drawing.Point(572, 94);
            this.Grp_TemPai.Name = "Grp_TemPai";
            this.Grp_TemPai.Size = new System.Drawing.Size(138, 46);
            this.Grp_TemPai.TabIndex = 9;
            this.Grp_TemPai.TabStop = false;
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(7, 19);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(113, 17);
            this.Chk_TemPai.TabIndex = 8;
            this.Chk_TemPai.Text = "Pai Desconhecido";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.label1);
            this.Grp_Endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_Endereco.Controls.Add(this.label2);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Controls.Add(this.Txt_CEP);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Location = new System.Drawing.Point(15, 268);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(794, 149);
            this.Grp_Endereco.TabIndex = 30;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estado";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(289, 33);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(283, 21);
            this.Cmb_Estados.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cidade";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cidade.Location = new System.Drawing.Point(577, 33);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(208, 20);
            this.Txt_Cidade.TabIndex = 12;
            // 
            // Grp_OutrosDados
            // 
            this.Grp_OutrosDados.Controls.Add(Lbl_Profissao);
            this.Grp_OutrosDados.Controls.Add(Lbl_Telefone);
            this.Grp_OutrosDados.Controls.Add(this.Txt_Telefone);
            this.Grp_OutrosDados.Controls.Add(this.Txt_RendaFamiliar);
            this.Grp_OutrosDados.Controls.Add(this.Txt_Profissao);
            this.Grp_OutrosDados.Controls.Add(Lbl_RendaFamiliar);
            this.Grp_OutrosDados.Location = new System.Drawing.Point(15, 423);
            this.Grp_OutrosDados.Name = "Grp_OutrosDados";
            this.Grp_OutrosDados.Size = new System.Drawing.Size(791, 77);
            this.Grp_OutrosDados.TabIndex = 20;
            this.Grp_OutrosDados.TabStop = false;
            this.Grp_OutrosDados.Text = "Outros Dados";
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.CancelartoolStripButton,
            this.ApagatoolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(814, 25);
            this.Tls_Principal.TabIndex = 31;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // CancelartoolStripButton
            // 
            this.CancelartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelartoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.CancelartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelartoolStripButton.Name = "CancelartoolStripButton";
            this.CancelartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CancelartoolStripButton.Text = "Cancelar";
            this.CancelartoolStripButton.Click += new System.EventHandler(this.CancelartoolStripButton_Click);
            // 
            // ApagatoolStripButton
            // 
            this.ApagatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.LimparBarra;
            this.ApagatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton.Name = "ApagatoolStripButton";
            this.ApagatoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton.Text = "Apagar";
            this.ApagatoolStripButton.Click += new System.EventHandler(this.ApagatoolStripButton_Click);
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Grp_OutrosDados);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_Código);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(814, 508);
            this.Grp_Código.ResumeLayout(false);
            this.Grp_Código.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_TemPai.ResumeLayout(false);
            this.Grp_TemPai.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_OutrosDados.ResumeLayout(false);
            this.Grp_OutrosDados.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.TextBox Txt_Telefone;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.TextBox Txt_RendaFamiliar;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox Grp_Código;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.GroupBox Grp_OutrosDados;
        private System.Windows.Forms.GroupBox Grp_TemPai;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.RadioButton Rdb_Outros;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton;
        private System.Windows.Forms.ToolStripButton CancelartoolStripButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Estados;
    }
}
