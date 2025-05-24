namespace Aula02
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbNome = new TextBox();
            txbIdade = new TextBox();
            txbPeso = new TextBox();
            btnCadastrar = new Button();
            rbSim = new RadioButton();
            rbNao = new RadioButton();
            cbSexo = new ComboBox();
            dvListaPessoas = new DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            label6 = new Label();
            lblContador = new Label();
            label7 = new Label();
            txbAltura = new TextBox();
            txbIMC = new TextBox();
            label8 = new Label();
            button1 = new Button();
            txbCEP = new TextBox();
            label9 = new Label();
            txbEndereco = new TextBox();
            txbNumero = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)dvListaPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 282);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 335);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Ativo";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(371, 80);
            txbNome.Margin = new Padding(4, 5, 4, 5);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(141, 31);
            txbNome.TabIndex = 5;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(371, 205);
            txbIdade.Margin = new Padding(4, 5, 4, 5);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(141, 31);
            txbIdade.TabIndex = 7;
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(370, 268);
            txbPeso.Margin = new Padding(4, 5, 4, 5);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(141, 31);
            txbPeso.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(253, 442);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(107, 38);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Location = new Point(373, 332);
            rbSim.Margin = new Padding(4, 5, 4, 5);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(67, 29);
            rbSim.TabIndex = 11;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Location = new Point(534, 332);
            rbNao.Margin = new Padding(4, 5, 4, 5);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(70, 29);
            rbNao.TabIndex = 12;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Definido" });
            cbSexo.Location = new Point(373, 142);
            cbSexo.Margin = new Padding(4, 5, 4, 5);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(171, 33);
            cbSexo.TabIndex = 13;
            // 
            // dvListaPessoas
            // 
            dvListaPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvListaPessoas.Location = new Point(93, 497);
            dvListaPessoas.Margin = new Padding(4, 5, 4, 5);
            dvListaPessoas.Name = "dvListaPessoas";
            dvListaPessoas.RowHeadersWidth = 62;
            dvListaPessoas.Size = new Size(994, 250);
            dvListaPessoas.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(490, 442);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(111, 33);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(731, 442);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 33);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(827, 378);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 17;
            label6.Text = "Contagem:";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(932, 378);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(22, 25);
            lblContador.TabIndex = 18;
            lblContador.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(691, 86);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 19;
            label7.Text = "Altura";
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(756, 80);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(150, 31);
            txbAltura.TabIndex = 20;
            // 
            // txbIMC
            // 
            txbIMC.Location = new Point(756, 142);
            txbIMC.Name = "txbIMC";
            txbIMC.ReadOnly = true;
            txbIMC.Size = new Size(150, 31);
            txbIMC.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(691, 148);
            label8.Name = "label8";
            label8.Size = new Size(44, 25);
            label8.TabIndex = 21;
            label8.Text = "IMC";
            // 
            // button1
            // 
            button1.Location = new Point(932, 202);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 23;
            button1.Text = "buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txbCEP
            // 
            txbCEP.Location = new Point(756, 202);
            txbCEP.Name = "txbCEP";
            txbCEP.Size = new Size(150, 31);
            txbCEP.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(693, 202);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 25;
            label9.Text = "CEP";
            // 
            // txbEndereco
            // 
            txbEndereco.Location = new Point(756, 256);
            txbEndereco.Multiline = true;
            txbEndereco.Name = "txbEndereco";
            txbEndereco.ReadOnly = true;
            txbEndereco.Size = new Size(292, 67);
            txbEndereco.TabIndex = 26;
            // 
            // txbNumero
            // 
            txbNumero.Location = new Point(756, 329);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(150, 31);
            txbNumero.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(673, 335);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 28;
            label10.Text = "Número";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(665, 256);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 29;
            label11.Text = "Endereço";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(93, 378);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(174, 34);
            btnUpload.TabIndex = 30;
            btnUpload.Text = "Upload Arquivo";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 797);
            Controls.Add(btnUpload);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txbNumero);
            Controls.Add(txbEndereco);
            Controls.Add(label9);
            Controls.Add(txbCEP);
            Controls.Add(button1);
            Controls.Add(txbIMC);
            Controls.Add(label8);
            Controls.Add(txbAltura);
            Controls.Add(label7);
            Controls.Add(lblContador);
            Controls.Add(label6);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(dvListaPessoas);
            Controls.Add(cbSexo);
            Controls.Add(rbNao);
            Controls.Add(rbSim);
            Controls.Add(btnCadastrar);
            Controls.Add(txbPeso);
            Controls.Add(txbIdade);
            Controls.Add(txbNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)dvListaPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbNome;
        private TextBox txbIdade;
        private TextBox txbPeso;
        private Button btnCadastrar;
        private RadioButton rbSim;
        private RadioButton rbNao;
        private ComboBox cbSexo;
        private DataGridView dvListaPessoas;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label6;
        private Label lblContador;
        private Label label7;
        private TextBox txbAltura;
        private TextBox txbIMC;
        private Label label8;
        private Button button1;
        private TextBox txbCEP;
        private Label label9;
        private TextBox txbEndereco;
        private TextBox txbNumero;
        private Label label10;
        private Label label11;
        private Button btnUpload;
    }
}