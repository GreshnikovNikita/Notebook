namespace Контакти
{
    partial class OrganisationsChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganisationsChangeForm));
            this.OrganisationsChangePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.IdField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrganisationsChangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganisationsChangePanel
            // 
            this.OrganisationsChangePanel.BackColor = System.Drawing.Color.White;
            this.OrganisationsChangePanel.Controls.Add(this.label1);
            this.OrganisationsChangePanel.Controls.Add(this.pictureBox1);
            this.OrganisationsChangePanel.Controls.Add(this.CloseButton);
            this.OrganisationsChangePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrganisationsChangePanel.Location = new System.Drawing.Point(0, 0);
            this.OrganisationsChangePanel.Name = "OrganisationsChangePanel";
            this.OrganisationsChangePanel.Size = new System.Drawing.Size(390, 44);
            this.OrganisationsChangePanel.TabIndex = 27;
            this.OrganisationsChangePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrganisationsChangePanel_MouseDown);
            this.OrganisationsChangePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrganisationsChangePanel_MouseMove);
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
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(349, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 45);
            this.NameLabel.TabIndex = 52;
            this.NameLabel.Text = "!";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.White;
            this.TypeLabel.Location = new System.Drawing.Point(349, 187);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(33, 45);
            this.TypeLabel.TabIndex = 51;
            this.TypeLabel.Text = "!";
            this.TypeLabel.Click += new System.EventHandler(this.TypeLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddressLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(349, 240);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(33, 45);
            this.AddressLabel.TabIndex = 50;
            this.AddressLabel.Text = "!";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(349, 293);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(33, 45);
            this.PhoneLabel.TabIndex = 49;
            this.PhoneLabel.Text = "!";
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(349, 346);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(33, 45);
            this.EmailLabel.TabIndex = 48;
            this.EmailLabel.Text = "!";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
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
            this.IdLabel.TabIndex = 54;
            this.IdLabel.Text = "!";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangeButton.BackColor = System.Drawing.Color.White;
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(75, 420);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(227, 60);
            this.ChangeButton.TabIndex = 55;
            this.ChangeButton.Text = "Змінити організацію";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // IdField
            // 
            this.IdField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdField.ForeColor = System.Drawing.Color.Gray;
            this.IdField.Location = new System.Drawing.Point(45, 81);
            this.IdField.Multiline = true;
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(298, 47);
            this.IdField.TabIndex = 61;
            this.IdField.Text = "Введіть ідентифікатор\r\n";
            this.IdField.Enter += new System.EventHandler(this.IdField_Enter);
            this.IdField.Leave += new System.EventHandler(this.IdField_Leave);
            // 
            // EmailField
            // 
            this.EmailField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailField.BackColor = System.Drawing.Color.White;
            this.EmailField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.White;
            this.EmailField.Location = new System.Drawing.Point(45, 346);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.Size = new System.Drawing.Size(298, 47);
            this.EmailField.TabIndex = 60;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // PhoneField
            // 
            this.PhoneField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneField.BackColor = System.Drawing.Color.White;
            this.PhoneField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.ForeColor = System.Drawing.Color.White;
            this.PhoneField.Location = new System.Drawing.Point(45, 293);
            this.PhoneField.Multiline = true;
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(298, 47);
            this.PhoneField.TabIndex = 59;
            this.PhoneField.Enter += new System.EventHandler(this.PhoneField_Enter);
            this.PhoneField.Leave += new System.EventHandler(this.PhoneField_Leave);
            // 
            // AddressField
            // 
            this.AddressField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddressField.BackColor = System.Drawing.Color.White;
            this.AddressField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressField.ForeColor = System.Drawing.Color.White;
            this.AddressField.Location = new System.Drawing.Point(45, 240);
            this.AddressField.Multiline = true;
            this.AddressField.Name = "AddressField";
            this.AddressField.ReadOnly = true;
            this.AddressField.Size = new System.Drawing.Size(298, 47);
            this.AddressField.TabIndex = 58;
            this.AddressField.Enter += new System.EventHandler(this.AddressField_Enter);
            this.AddressField.Leave += new System.EventHandler(this.AddressField_Leave);
            // 
            // TypeField
            // 
            this.TypeField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TypeField.BackColor = System.Drawing.Color.White;
            this.TypeField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeField.ForeColor = System.Drawing.Color.White;
            this.TypeField.Location = new System.Drawing.Point(45, 187);
            this.TypeField.Multiline = true;
            this.TypeField.Name = "TypeField";
            this.TypeField.ReadOnly = true;
            this.TypeField.Size = new System.Drawing.Size(298, 47);
            this.TypeField.TabIndex = 57;
            this.TypeField.Enter += new System.EventHandler(this.TypeField_Enter);
            this.TypeField.Leave += new System.EventHandler(this.TypeField_Leave);
            // 
            // NameField
            // 
            this.NameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameField.BackColor = System.Drawing.Color.White;
            this.NameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.White;
            this.NameField.Location = new System.Drawing.Point(45, 134);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(298, 47);
            this.NameField.TabIndex = 56;
            this.NameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.NameField.Leave += new System.EventHandler(this.NameField_Leave);
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
            // OrganisationsChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 509);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.OrganisationsChangePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationsChangeForm";
            this.Text = "Form8";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrganisationsChangeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrganisationsChangeForm_MouseMove);
            this.OrganisationsChangePanel.ResumeLayout(false);
            this.OrganisationsChangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OrganisationsChangePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox TypeField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}