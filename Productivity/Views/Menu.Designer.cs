namespace Productivity
{
    partial class Menu
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
            this.name = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.pomodoroOption = new System.Windows.Forms.Button();
            this.Estatísticas = new System.Windows.Forms.Button();
            this.taskOption = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(613, 288);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 190);
            this.name.TabIndex = 11;
            this.name.Text = "Nome da pessoa da silva";
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(212, 398);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(255, 79);
            this.quit.TabIndex = 9;
            this.quit.Text = "Sair";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // pomodoroOption
            // 
            this.pomodoroOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroOption.Location = new System.Drawing.Point(212, 288);
            this.pomodoroOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomodoroOption.Name = "pomodoroOption";
            this.pomodoroOption.Size = new System.Drawing.Size(255, 79);
            this.pomodoroOption.TabIndex = 8;
            this.pomodoroOption.Text = "Pomodoro";
            this.pomodoroOption.UseVisualStyleBackColor = true;
            this.pomodoroOption.Click += new System.EventHandler(this.pomodoroOption_Click);
            // 
            // Estatísticas
            // 
            this.Estatísticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estatísticas.Location = new System.Drawing.Point(212, 183);
            this.Estatísticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Estatísticas.Name = "Estatísticas";
            this.Estatísticas.Size = new System.Drawing.Size(255, 79);
            this.Estatísticas.TabIndex = 7;
            this.Estatísticas.Text = "Estatísticas";
            this.Estatísticas.UseVisualStyleBackColor = true;
            this.Estatísticas.Click += new System.EventHandler(this.Estatísticas_Click);
            // 
            // taskOption
            // 
            this.taskOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOption.Location = new System.Drawing.Point(212, 79);
            this.taskOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskOption.Name = "taskOption";
            this.taskOption.Size = new System.Drawing.Size(255, 79);
            this.taskOption.TabIndex = 6;
            this.taskOption.Text = "Tarefas";
            this.taskOption.UseVisualStyleBackColor = true;
            this.taskOption.Click += new System.EventHandler(this.taskOption_Click);
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Location = new System.Drawing.Point(613, 79);
            this.profilePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(233, 188);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 10;
            this.profilePic.TabStop = false;
            this.profilePic.Click += new System.EventHandler(this.profilePic_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mudar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pomodoroOption);
            this.Controls.Add(this.Estatísticas);
            this.Controls.Add(this.taskOption);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1085, 601);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button pomodoroOption;
        private System.Windows.Forms.Button Estatísticas;
        private System.Windows.Forms.Button taskOption;
        private System.Windows.Forms.Button button1;
    }
}