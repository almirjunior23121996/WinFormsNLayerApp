namespace WindowsForms.telas.clientes
{
    partial class ClienteCadastrar
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
            dtpNascimento = new DateTimePicker();
            txtNomeCompleto = new TextBox();
            txtCpf = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            cmbBolsaEstudos = new ComboBox();
            chkEhResponsavel = new CheckBox();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 27);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(176, 78);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(470, 23);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Cpf";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(176, 107);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(288, 23);
            dtpNascimento.TabIndex = 3;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNomeCompleto.Location = new Point(176, 45);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(283, 23);
            txtNomeCompleto.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.Location = new Point(470, 45);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(137, 23);
            txtCpf.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sem_foto;
            pictureBox1.Image = Properties.Resources.sem_foto;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(176, 148);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(392, 148);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefone.Location = new Point(176, 166);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(211, 23);
            txtTelefone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(392, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(176, 214);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 11;
            label6.Text = "Bolsa de estudos";
            // 
            // cmbBolsaEstudos
            // 
            cmbBolsaEstudos.FormattingEnabled = true;
            cmbBolsaEstudos.Location = new Point(177, 239);
            cmbBolsaEstudos.Name = "cmbBolsaEstudos";
            cmbBolsaEstudos.Size = new Size(121, 23);
            cmbBolsaEstudos.TabIndex = 12;
            // 
            // chkEhResponsavel
            // 
            chkEhResponsavel.AutoSize = true;
            chkEhResponsavel.Location = new Point(179, 285);
            chkEhResponsavel.Name = "chkEhResponsavel";
            chkEhResponsavel.Size = new Size(180, 19);
            chkEhResponsavel.TabIndex = 13;
            chkEhResponsavel.Text = "Cliente é o responsavel legal?";
            chkEhResponsavel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(180, 347);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 14;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(chkEhResponsavel);
            Controls.Add(cmbBolsaEstudos);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeCompleto);
            Controls.Add(dtpNascimento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteCadastrar";
            Text = "ClienteCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpNascimento;
        private TextBox txtNomeCompleto;
        private TextBox txtCpf;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label6;
        private ComboBox cmbBolsaEstudos;
        private CheckBox chkEhResponsavel;
        private Button btnOk;
    }
}