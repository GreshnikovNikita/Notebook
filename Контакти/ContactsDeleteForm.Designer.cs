namespace Контакти
{
    partial class DeleteNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteNote));
            this.DeleteNotePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.BirthDateField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.IdField = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteNotePanel
            // 
            this.DeleteNotePanel.BackColor = System.Drawing.Color.White;
            this.DeleteNotePanel.Controls.Add(this.label1);
            this.DeleteNotePanel.Controls.Add(this.pictureBox1);
            this.DeleteNotePanel.Controls.Add(this.CloseButton);
            this.DeleteNotePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteNotePanel.Location = new System.Drawing.Point(0, 0);
            this.DeleteNotePanel.Name = "DeleteNotePanel";
            this.DeleteNotePanel.Size = new System.Drawing.Size(390, 44);
            this.DeleteNotePanel.TabIndex = 27;
            this.DeleteNotePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteNotePanel_MouseDown);
            this.DeleteNotePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteNotePanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(345, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 26);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BirthDateField
            // 
            this.BirthDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateField.BackColor = System.Drawing.Color.White;
            this.BirthDateField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateField.ForeColor = System.Drawing.Color.White;
            this.BirthDateField.Location = new System.Drawing.Point(46, 397);
            this.BirthDateField.Multiline = true;
            this.BirthDateField.Name = "BirthDateField";
            this.BirthDateField.ReadOnly = true;
            this.BirthDateField.Size = new System.Drawing.Size(298, 47);
            this.BirthDateField.TabIndex = 43;
            // 
            // AddressField
            // 
            this.AddressField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressField.BackColor = System.Drawing.Color.White;
            this.AddressField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressField.ForeColor = System.Drawing.Color.White;
            this.AddressField.Location = new System.Drawing.Point(45, 344);
            this.AddressField.Multiline = true;
            this.AddressField.Name = "AddressField";
            this.AddressField.ReadOnly = true;
            this.AddressField.Size = new System.Drawing.Size(298, 47);
            this.AddressField.TabIndex = 42;
            // 
            // EmailField
            // 
            this.EmailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailField.BackColor = System.Drawing.Color.White;
            this.EmailField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.White;
            this.EmailField.Location = new System.Drawing.Point(46, 291);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.Size = new System.Drawing.Size(298, 47);
            this.EmailField.TabIndex = 41;
            // 
            // PhoneField
            // 
            this.PhoneField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneField.BackColor = System.Drawing.Color.White;
            this.PhoneField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.ForeColor = System.Drawing.Color.White;
            this.PhoneField.Location = new System.Drawing.Point(45, 238);
            this.PhoneField.Multiline = true;
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(298, 47);
            this.PhoneField.TabIndex = 40;
            // 
            // SurnameField
            // 
            this.SurnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameField.BackColor = System.Drawing.Color.White;
            this.SurnameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameField.ForeColor = System.Drawing.Color.White;
            this.SurnameField.Location = new System.Drawing.Point(45, 185);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.ReadOnly = true;
            this.SurnameField.Size = new System.Drawing.Size(298, 47);
            this.SurnameField.TabIndex = 39;
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.BackColor = System.Drawing.Color.White;
            this.NameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.White;
            this.NameField.Location = new System.Drawing.Point(45, 132);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(298, 47);
            this.NameField.TabIndex = 38;
            // 
            // IdField
            // 
            this.IdField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdField.BackColor = System.Drawing.Color.White;
            this.IdField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdField.ForeColor = System.Drawing.Color.Gray;
            this.IdField.Location = new System.Drawing.Point(45, 79);
            this.IdField.Multiline = true;
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(298, 47);
            this.IdField.TabIndex = 37;
            this.IdField.Text = "Введіть ідентифікатор";
            this.IdField.Enter += new System.EventHandler(this.IdField_Enter);
            this.IdField.Leave += new System.EventHandler(this.IdField_Leave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(75, 472);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(227, 60);
            this.DeleteButton.TabIndex = 36;
            this.DeleteButton.Text = "Видалити контакт";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.White;
            this.IdLabel.Location = new System.Drawing.Point(349, 81);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(33, 45);
            this.IdLabel.TabIndex = 50;
            this.IdLabel.Text = "!";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notebook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Контакти.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 585);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BirthDateField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteNotePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteNote";
            this.Text = "Form5";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteNote_MouseMove);
            this.DeleteNotePanel.ResumeLayout(false);
            this.DeleteNotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DeleteNotePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.TextBox BirthDateField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}