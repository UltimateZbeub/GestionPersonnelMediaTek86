
namespace GestionPersonnelMediaTek86.view
{
    /// <summary>
    /// Formulaire de gestion du login.
    /// </summary>
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources utilisées par le formulaire.
        /// </summary>
        /// <param name="disposing">Indique si les ressources managées doivent être libérées.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";

            this.txtLogin.Location = new System.Drawing.Point(60, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 1;

            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(12, 45);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(53, 13);
            this.labelPwd.TabIndex = 2;
            this.labelPwd.Text = "Password";

            this.txtPwd.Location = new System.Drawing.Point(60, 42);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(180, 20);
            this.txtPwd.TabIndex = 3;

            this.btnConnect.Location = new System.Drawing.Point(149, 75);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);

            this.ClientSize = new System.Drawing.Size(260, 110);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelLogin);
            this.Name = "FrmLogin";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnConnect;
    }
}
