namespace Productivity
{
    partial class Registro
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
            this.registerbox = new System.Windows.Forms.GroupBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.telebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.registerbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerbox
            // 
            this.registerbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerbox.Controls.Add(this.cancelbutton);
            this.registerbox.Controls.Add(this.register);
            this.registerbox.Controls.Add(this.telebox);
            this.registerbox.Controls.Add(this.label2);
            this.registerbox.Controls.Add(this.email);
            this.registerbox.Controls.Add(this.emailbox);
            this.registerbox.Controls.Add(this.passbox);
            this.registerbox.Controls.Add(this.senha);
            this.registerbox.Controls.Add(this.label1);
            this.registerbox.Controls.Add(this.namebox);
            this.registerbox.Location = new System.Drawing.Point(16, 15);
            this.registerbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerbox.Name = "registerbox";
            this.registerbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerbox.Size = new System.Drawing.Size(591, 213);
            this.registerbox.TabIndex = 0;
            this.registerbox.TabStop = false;
            this.registerbox.Text = "Registro";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbutton.Location = new System.Drawing.Point(375, 177);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(100, 28);
            this.cancelbutton.TabIndex = 9;
            this.cancelbutton.Text = "Cancelar";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.register.Location = new System.Drawing.Point(483, 177);
            this.register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 28);
            this.register.TabIndex = 8;
            this.register.Text = "Registrar";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // telebox
            // 
            this.telebox.Location = new System.Drawing.Point(324, 124);
            this.telebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telebox.Name = "telebox";
            this.telebox.Size = new System.Drawing.Size(223, 22);
            this.telebox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(324, 44);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 16);
            this.email.TabIndex = 5;
            this.email.Text = "E-Mail";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(324, 64);
            this.emailbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(223, 22);
            this.emailbox.TabIndex = 4;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(12, 124);
            this.passbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(223, 22);
            this.passbox.TabIndex = 3;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(12, 105);
            this.senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(46, 16);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(12, 63);
            this.namebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(223, 22);
            this.namebox.TabIndex = 0;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 242);
            this.Controls.Add(this.registerbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro";
            this.Text = "Registro";
            this.registerbox.ResumeLayout(false);
            this.registerbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox telebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button cancelbutton;
    }
}