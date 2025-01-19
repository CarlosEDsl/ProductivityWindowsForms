namespace Productivity
{
    partial class Estatísticas
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
            this.hourPerMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTasks = new System.Windows.Forms.Label();
            this.percentualFinished = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tasksPerMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.hourPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksPerMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // hourPerMonth
            // 
            this.hourPerMonth.BackColor = System.Drawing.Color.Transparent;
            this.hourPerMonth.BorderlineColor = System.Drawing.Color.Transparent;
            this.hourPerMonth.Location = new System.Drawing.Point(16, 284);
            this.hourPerMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourPerMonth.Name = "hourPerMonth";
            this.hourPerMonth.Size = new System.Drawing.Size(485, 255);
            this.hourPerMonth.TabIndex = 0;
            this.hourPerMonth.Text = "chart1";
            this.hourPerMonth.Click += new System.EventHandler(this.hourPerMonth_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(120, 11);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(240, 39);
            this.total.TabIndex = 3;
            this.total.Text = "Total de Tasks";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Percentual Concluído";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalTasks
            // 
            this.totalTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTasks.Location = new System.Drawing.Point(127, 92);
            this.totalTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTasks.Name = "totalTasks";
            this.totalTasks.Size = new System.Drawing.Size(233, 91);
            this.totalTasks.TabIndex = 5;
            this.totalTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentualFinished
            // 
            this.percentualFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentualFinished.Location = new System.Drawing.Point(577, 92);
            this.percentualFinished.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentualFinished.Name = "percentualFinished";
            this.percentualFinished.Size = new System.Drawing.Size(403, 91);
            this.percentualFinished.TabIndex = 6;
            this.percentualFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentualFinished.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total de Horas por mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total concluído por mês";
            // 
            // tasksPerMonth
            // 
            this.tasksPerMonth.BackColor = System.Drawing.Color.Transparent;
            this.tasksPerMonth.Location = new System.Drawing.Point(565, 284);
            this.tasksPerMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tasksPerMonth.Name = "tasksPerMonth";
            this.tasksPerMonth.Size = new System.Drawing.Size(485, 255);
            this.tasksPerMonth.TabIndex = 1;
            this.tasksPerMonth.Text = "chart2";
            // 
            // Estatísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.percentualFinished);
            this.Controls.Add(this.totalTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tasksPerMonth);
            this.Controls.Add(this.hourPerMonth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1085, 601);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "Estatísticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.Estatísticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksPerMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart hourPerMonth;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTasks;
        private System.Windows.Forms.Label percentualFinished;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart tasksPerMonth;
    }
}