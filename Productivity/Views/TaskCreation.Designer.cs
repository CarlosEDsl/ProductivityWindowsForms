namespace Productivity.Views
{
    partial class TaskCreation
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
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.term = new System.Windows.Forms.Label();
            this.termPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Location = new System.Drawing.Point(218, 289);
            this.create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(56, 28);
            this.create.TabIndex = 0;
            this.create.Text = "Criar";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(148, 289);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(66, 28);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(44, 18);
            this.title.TabIndex = 2;
            this.title.Text = "Título";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 28);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(261, 20);
            this.titleBox.TabIndex = 3;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(9, 62);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(76, 18);
            this.Description.TabIndex = 4;
            this.Description.Text = "Descrição";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 82);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(261, 97);
            this.descriptionBox.TabIndex = 5;
            this.descriptionBox.Text = "";
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term.Location = new System.Drawing.Point(9, 195);
            this.term.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(48, 18);
            this.term.TabIndex = 6;
            this.term.Text = "Prazo";
            // 
            // termPicker
            // 
            this.termPicker.Location = new System.Drawing.Point(9, 215);
            this.termPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.termPicker.Name = "termPicker";
            this.termPicker.Size = new System.Drawing.Size(264, 20);
            this.termPicker.TabIndex = 7;
            this.termPicker.ValueChanged += new System.EventHandler(this.termPicker_ValueChanged);
            // 
            // TaskCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 340);
            this.Controls.Add(this.termPicker);
            this.Controls.Add(this.term);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 379);
            this.MinimumSize = new System.Drawing.Size(312, 379);
            this.Name = "TaskCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.DateTimePicker termPicker;
    }
}