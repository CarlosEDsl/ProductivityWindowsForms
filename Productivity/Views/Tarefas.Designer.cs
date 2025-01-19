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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.createTask.Location = new System.Drawing.Point(688, 15);
            this.createTask.Margin = new System.Windows.Forms.Padding(4);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(83, 63);
            this.createTask.TabIndex = 0;
            this.createTask.Text = "➕";
            this.createTask.UseVisualStyleBackColor = false;
            this.createTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(11, 15);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(274, 39);
            this.total.TabIndex = 2;
            this.total.Text = "Total de N Tasks";
            this.total.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.AutoSize = true;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(18, 159);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.flowPanel.MaximumSize = new System.Drawing.Size(752, 350);
            this.flowPanel.MinimumSize = new System.Drawing.Size(752, 300);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.flowPanel.Size = new System.Drawing.Size(752, 350);
            this.flowPanel.TabIndex = 4;
            this.flowPanel.WrapContents = false;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 584);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.createTask);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 631);
            this.MinimumSize = new System.Drawing.Size(805, 631);
            this.Name = "Tarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.Tarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}