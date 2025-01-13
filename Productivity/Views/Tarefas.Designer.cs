namespace Productivity
{
    partial class Tarefas
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
            this.createTask = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // createTask
            // 
            this.createTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createTask.BackColor = System.Drawing.Color.Transparent;
            this.createTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.createTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTask.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createTask.Location = new System.Drawing.Point(540, 12);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(62, 51);
            this.createTask.TabIndex = 0;
            this.createTask.Text = "➕";
            this.createTask.UseVisualStyleBackColor = false;
            this.createTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(8, 12);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(220, 31);
            this.total.TabIndex = 2;
            this.total.Text = "Total de N Tasks";
            this.total.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Tarefas";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 236);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 373);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.createTask);
            this.Name = "Tarefas";
            this.Text = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}