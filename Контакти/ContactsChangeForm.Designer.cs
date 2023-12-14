namespace Контакти
{
    partial class ChangeNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeNote));
            this.AddNotePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.IdField = new System.Windows.Forms.TextBox();
            this.BirthDateField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNotePanel
            // 
            this.AddNotePanel.BackColor = System.Drawing.Color.White;
            this.AddNotePanel.Controls.Add(this.label1);
            this.AddNotePanel.Controls.Add(this.pictureBox1);
            this.AddNotePanel.Controls.Add(this.CloseButton);
            this.AddNotePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNotePanel.Location = new System.Drawing.Point(0, 0);
            this.AddNotePanel.Name = "AddNotePanel";
            this.AddNotePanel.Size = new System.Drawing.Size(390, 44);
            this.AddNotePanel.TabIndex = 26;
            this.AddNotePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNotePanel_MouseDown);
            this.AddNotePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNotePanel_MouseMove);
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
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeButton.BackColor = System.Drawing.Color.White;
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(75, 472);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(227, 60);
            this.ChangeButton.TabIndex = 27;
            this.ChangeButton.Text = "Змінити контакт";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // IdField
            // 
            this.IdField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdField.ForeColor = System.Drawing.Color.Gray;
            this.IdField.Location = new System.Drawing.Point(45, 79);
            this.IdField.Multiline = true;
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(298, 47);
            this.IdField.TabIndex = 29;
            this.IdField.Text = "Введіть ідентифікатор";
            this.IdField.Enter += new System.EventHandler(this.IdField_Enter);
            this.IdField.Leave += new System.EventHandler(this.IdField_Leave);
            // 
            // BirthDateField
            // 
            this.BirthDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateField.BackColor = System.Drawing.Color.White;
            this.BirthDateField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateField.ForeColor = System.Drawing.Color.White;
            this.BirthDateField.Location = new System.Drawing.Point(45, 397);
            this.BirthDateField.Multiline = true;
            this.BirthDateField.Name = "BirthDateField";
            this.BirthDateField.Size = new System.Drawing.Size(298, 47);
            this.BirthDateField.TabIndex = 35;
            this.BirthDateField.Enter += new System.EventHandler(this.BirthDateField_Enter);
            this.BirthDateField.Leave += new System.EventHandler(this.BirthDateField_Leave);
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
            this.AddressField.Size = new System.Drawing.Size(298, 47);
            this.AddressField.TabIndex = 34;
            this.AddressField.Enter += new System.EventHandler(this.AddressField_Enter);
            this.AddressField.Leave += new System.EventHandler(this.AddressField_Leave);
            // 
            // EmailField
            // 
            this.EmailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailField.BackColor = System.Drawing.Color.White;
            this.EmailField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.White;
            this.EmailField.Location = new System.Drawing.Point(45, 291);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(298, 47);
            this.EmailField.TabIndex = 33;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
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
            this.PhoneField.Size = new System.Drawing.Size(298, 47);
            this.PhoneField.TabIndex = 32;
            this.PhoneField.Enter += new System.EventHandler(this.PhoneField_Enter);
            this.PhoneField.Leave += new System.EventHandler(this.PhoneField_Leave);
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
            this.SurnameField.Size = new System.Drawing.Size(298, 47);
            this.SurnameField.TabIndex = 31;
            this.SurnameField.Enter += new System.EventHandler(this.SurnameField_Enter);
            this.SurnameField.Leave += new System.EventHandler(this.SurnameField_Leave);
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
            this.NameField.Size = new System.Drawing.Size(298, 47);
            this.NameField.TabIndex = 30;
            this.NameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.NameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(349, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 45);
            this.label6.TabIndex = 41;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(349, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 45);
            this.NameLabel.TabIndex = 43;
            this.NameLabel.Text = "!";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurnameLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameLabel.Location = new System.Drawing.Point(349, 187);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(33, 45);
            this.SurnameLabel.TabIndex = 44;
            this.SurnameLabel.Text = "!";
            this.SurnameLabel.Click += new System.EventHandler(this.SurnameLabel_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(349, 240);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(33, 45);
            this.PhoneLabel.TabIndex = 45;
            this.PhoneLabel.Text = "!";
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(349, 293);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(33, 45);
            this.EmailLabel.TabIndex = 46;
            this.EmailLabel.Text = "!";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddressLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(349, 346);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(33, 45);
            this.AddressLabel.TabIndex = 47;
            this.AddressLabel.Text = "!";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BirthDateLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthDateLabel.Location = new System.Drawing.Point(349, 399);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(33, 45);
            this.BirthDateLabel.TabIndex = 48;
            this.BirthDateLabel.Text = "!";
            this.BirthDateLabel.Click += new System.EventHandler(this.BirthDateLabel_Click);
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
            this.IdLabel.TabIndex = 49;
            this.IdLabel.Text = "!";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notebook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Контакти.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 585);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthDateField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AddNotePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeNote";
            this.Text = "Form4";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeNote_MouseMove);
            this.AddNotePanel.ResumeLayout(false);
            this.AddNotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AddNotePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.TextBox BirthDateField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}