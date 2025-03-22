namespace Aula02
{
    partial class formEdicao
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
            cbSexo = new ComboBox();
            rbSim = new RadioButton();
            rbNao = new RadioButton();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Ativo";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(136, 20);
            txbNome.Margin = new Padding(4, 5, 4, 5);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(141, 31);
            txbNome.TabIndex = 5;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(136, 125);
            txbIdade.Margin = new Padding(4, 5, 4, 5);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(141, 31);
            txbIdade.TabIndex = 6;
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(136, 173);
            txbPeso.Margin = new Padding(4, 5, 4, 5);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(141, 31);
            txbPeso.TabIndex = 7;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino\t", "Feminino", "Não Definido" });
            cbSexo.Location = new Point(136, 77);
            cbSexo.Margin = new Padding(4, 5, 4, 5);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(141, 33);
            cbSexo.TabIndex = 8;
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Location = new Point(136, 233);
            rbSim.Margin = new Padding(4, 5, 4, 5);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(67, 29);
            rbSim.TabIndex = 9;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Location = new Point(264, 230);
            rbNao.Margin = new Padding(4, 5, 4, 5);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(70, 29);
            rbNao.TabIndex = 10;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(93, 303);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(107, 38);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(224, 303);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formEdicao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 362);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(rbNao);
            Controls.Add(rbSim);
            Controls.Add(cbSexo);
            Controls.Add(txbPeso);
            Controls.Add(txbIdade);
            Controls.Add(txbNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formEdicao";
            Text = "formEdicao";
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
        private ComboBox cbSexo;
        private RadioButton rbSim;
        private RadioButton rbNao;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}