namespace MecanicaForms
{
    partial class CadastroCliente
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
            btnLogin = new Button();
            InputSenha = new TextBox();
            InputEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 46);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de clientes";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(103, 80, 164);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(382, 411);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(183, 40);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // InputSenha
            // 
            InputSenha.Anchor = AnchorStyles.None;
            InputSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputSenha.Location = new Point(336, 350);
            InputSenha.Name = "InputSenha";
            InputSenha.PasswordChar = '*';
            InputSenha.Size = new Size(286, 39);
            InputSenha.TabIndex = 13;
            // 
            // InputEmail
            // 
            InputEmail.Anchor = AnchorStyles.None;
            InputEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputEmail.Location = new Point(336, 250);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(286, 39);
            InputEmail.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(336, 310);
            label3.Name = "label3";
            label3.Size = new Size(92, 37);
            label3.TabIndex = 11;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(336, 210);
            label2.Name = "label2";
            label2.Size = new Size(83, 37);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 717);
            Controls.Add(btnLogin);
            Controls.Add(InputSenha);
            Controls.Add(InputEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox InputSenha;
        private TextBox InputEmail;
        private Label label3;
        private Label label2;
    }
}