
namespace Clinica.HelpApplication
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelEfetuaLogin = new System.Windows.Forms.Label();
            this.labelSelecioneTipo = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUtente = new System.Windows.Forms.Button();
            this.buttonTerapeuta = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(66, 160);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 25);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(86, 64);
            this.textBoxNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNIF.MaxLength = 9;
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(239, 23);
            this.textBoxNIF.TabIndex = 1;
            this.textBoxNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNIF_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(86, 109);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(239, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(52, 67);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(28, 15);
            this.labelNIF.TabIndex = 3;
            this.labelNIF.Text = "NIF:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(20, 112);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(219, 160);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(86, 25);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelEfetuaLogin
            // 
            this.labelEfetuaLogin.AutoSize = true;
            this.labelEfetuaLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEfetuaLogin.Location = new System.Drawing.Point(100, 9);
            this.labelEfetuaLogin.Name = "labelEfetuaLogin";
            this.labelEfetuaLogin.Size = new System.Drawing.Size(174, 37);
            this.labelEfetuaLogin.TabIndex = 6;
            this.labelEfetuaLogin.Text = "Efetuar Login";
            // 
            // labelSelecioneTipo
            // 
            this.labelSelecioneTipo.AutoSize = true;
            this.labelSelecioneTipo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelecioneTipo.Location = new System.Drawing.Point(20, 9);
            this.labelSelecioneTipo.Name = "labelSelecioneTipo";
            this.labelSelecioneTipo.Size = new System.Drawing.Size(325, 37);
            this.labelSelecioneTipo.TabIndex = 7;
            this.labelSelecioneTipo.Text = "Selecione o tipo de Login:";
            this.labelSelecioneTipo.Visible = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(111, 63);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(149, 23);
            this.buttonAdmin.TabIndex = 8;
            this.buttonAdmin.Text = "Administrador";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Visible = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonUtente
            // 
            this.buttonUtente.Location = new System.Drawing.Point(111, 92);
            this.buttonUtente.Name = "buttonUtente";
            this.buttonUtente.Size = new System.Drawing.Size(149, 24);
            this.buttonUtente.TabIndex = 9;
            this.buttonUtente.Text = "Utente";
            this.buttonUtente.UseVisualStyleBackColor = true;
            this.buttonUtente.Visible = false;
            this.buttonUtente.Click += new System.EventHandler(this.buttonUtente_Click);
            // 
            // buttonTerapeuta
            // 
            this.buttonTerapeuta.Location = new System.Drawing.Point(113, 122);
            this.buttonTerapeuta.Name = "buttonTerapeuta";
            this.buttonTerapeuta.Size = new System.Drawing.Size(147, 24);
            this.buttonTerapeuta.TabIndex = 10;
            this.buttonTerapeuta.Text = "Terapeuta";
            this.buttonTerapeuta.UseVisualStyleBackColor = true;
            this.buttonTerapeuta.Visible = false;
            this.buttonTerapeuta.Click += new System.EventHandler(this.buttonTerapeuta_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(66, 160);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(84, 25);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 196);
            this.Controls.Add(this.labelEfetuaLogin);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonUtente);
            this.Controls.Add(this.buttonTerapeuta);
            this.Controls.Add(this.labelSelecioneTipo);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelEfetuaLogin;
        private System.Windows.Forms.Label labelSelecioneTipo;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonUtente;
        private System.Windows.Forms.Button buttonTerapeuta;
        private System.Windows.Forms.Button buttonLogout;
    }
}