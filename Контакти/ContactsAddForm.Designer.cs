namespace Контакти
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.AddButton = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.BirthDateField = new System.Windows.Forms.TextBox();
            this.AddNotePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddNotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(75, 414);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(227, 60);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Додати контакт";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.BackColor = System.Drawing.Color.White;
            this.NameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.Gray;
            this.NameField.Location = new System.Drawing.Point(45, 70);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(298, 47);
            this.NameField.TabIndex = 9;
            this.NameField.Text = "Введіть ім\'я";
            this.NameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.NameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // SurnameField
            // 
            this.SurnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameField.BackColor = System.Drawing.Color.White;
            this.SurnameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameField.ForeColor = System.Drawing.Color.Gray;
            this.SurnameField.Location = new System.Drawing.Point(45, 123);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(298, 47);
            this.SurnameField.TabIndex = 10;
            this.SurnameField.Text = "Введіть прізвище";
            this.SurnameField.Enter += new System.EventHandler(this.SurnameField_Enter);
            this.SurnameField.Leave += new System.EventHandler(this.SurnameField_Leave);
            // 
            // PhoneField
            // 
            this.PhoneField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneField.BackColor = System.Drawing.Color.White;
            this.PhoneField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.ForeColor = System.Drawing.Color.Gray;
            this.PhoneField.Location = new System.Drawing.Point(45, 176);
            this.PhoneField.Multiline = true;
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(298, 47);
            this.PhoneField.TabIndex = 11;
            this.PhoneField.Text = "Введіть телефон";
            this.PhoneField.Enter += new System.EventHandler(this.PhoneField_Enter);
            this.PhoneField.Leave += new System.EventHandler(this.PhoneField_Leave);
            // 
            // EmailField
            // 
            this.EmailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailField.BackColor = System.Drawing.Color.White;
            this.EmailField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.Gray;
            this.EmailField.Location = new System.Drawing.Point(45, 229);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(298, 47);
            this.EmailField.TabIndex = 12;
            this.EmailField.Text = "Введіть електронну пошту";
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // AddressField
            // 
            this.AddressField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressField.BackColor = System.Drawing.Color.White;
            this.AddressField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressField.ForeColor = System.Drawing.Color.Gray;
            this.AddressField.Location = new System.Drawing.Point(45, 282);
            this.AddressField.Multiline = true;
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(298, 47);
            this.AddressField.TabIndex = 13;
            this.AddressField.Text = "Введіть адресу";
            this.AddressField.Enter += new System.EventHandler(this.AddressField_Enter);
            this.AddressField.Leave += new System.EventHandler(this.AddressField_Leave);
            // 
            // BirthDateField
            // 
            this.BirthDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateField.BackColor = System.Drawing.Color.White;
            this.BirthDateField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateField.ForeColor = System.Drawing.Color.Gray;
            this.BirthDateField.Location = new System.Drawing.Point(45, 335);
            this.BirthDateField.Multiline = true;
            this.BirthDateField.Name = "BirthDateField";
            this.BirthDateField.Size = new System.Drawing.Size(298, 47);
            this.BirthDateField.TabIndex = 14;
            this.BirthDateField.Text = "Введіть дату народження";
            this.BirthDateField.Enter += new System.EventHandler(this.BirthDateField_Enter);
            this.BirthDateField.Leave += new System.EventHandler(this.BirthDateField_Leave);
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
            this.AddNotePanel.TabIndex = 18;
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
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BirthDateLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthDateLabel.Location = new System.Drawing.Point(349, 337);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(33, 45);
            this.BirthDateLabel.TabIndex = 24;
            this.BirthDateLabel.Text = "!";
            this.BirthDateLabel.Click += new System.EventHandler(this.BirthDateLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddressLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(349, 284);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(33, 45);
            this.AddressLabel.TabIndex = 25;
            this.AddressLabel.Text = "!";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(349, 231);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(33, 45);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "!";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(349, 178);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(33, 45);
            this.PhoneLabel.TabIndex = 27;
            this.PhoneLabel.Text = "!";
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurnameLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameLabel.Location = new System.Drawing.Point(349, 125);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(33, 45);
            this.SurnameLabel.TabIndex = 28;
            this.SurnameLabel.Text = "!";
            this.SurnameLabel.Click += new System.EventHandler(this.SurnameLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(349, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 45);
            this.NameLabel.TabIndex = 29;
            this.NameLabel.Text = "!";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
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
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 516);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.AddNotePanel);
            this.Controls.Add(this.BirthDateField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.AddButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNote";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNote_MouseMove);
            this.AddNotePanel.ResumeLayout(false);
            this.AddNotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox BirthDateField;
        private System.Windows.Forms.Panel AddNotePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}