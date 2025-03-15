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
            ((System.ComponentModel.ISupportInitialize)dvListaPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 79);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 117);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 151);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 176);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 210);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Ativo";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(260, 71);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(100, 23);
            txbNome.TabIndex = 5;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(260, 143);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(100, 23);
            txbIdade.TabIndex = 7;
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(260, 173);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(100, 23);
            txbPeso.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(373, 252);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Location = new Point(260, 208);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(45, 19);
            rbSim.TabIndex = 11;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Location = new Point(373, 208);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(47, 19);
            rbNao.TabIndex = 12;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Definido" });
            cbSexo.Location = new Point(261, 114);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(121, 23);
            cbSexo.TabIndex = 13;
            // 
            // dvListaPessoas
            // 
            dvListaPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvListaPessoas.Location = new Point(65, 298);
            dvListaPessoas.Name = "dvListaPessoas";
            dvListaPessoas.Size = new Size(696, 150);
            dvListaPessoas.TabIndex = 14;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}