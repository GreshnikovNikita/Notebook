namespace Контакти
{
    partial class OrganisationsDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganisationsDeleteForm));
            this.OrganisationsDeletePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.IdField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrganisationsDeletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganisationsDeletePanel
            // 
            this.OrganisationsDeletePanel.BackColor = System.Drawing.Color.White;
            this.OrganisationsDeletePanel.Controls.Add(this.label1);
            this.OrganisationsDeletePanel.Controls.Add(this.pictureBox1);
            this.OrganisationsDeletePanel.Controls.Add(this.CloseButton);
            this.OrganisationsDeletePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrganisationsDeletePanel.Location = new System.Drawing.Point(0, 0);
            this.OrganisationsDeletePanel.Name = "OrganisationsDeletePanel";
            this.OrganisationsDeletePanel.Size = new System.Drawing.Size(390, 44);
            this.OrganisationsDeletePanel.TabIndex = 28;
            this.OrganisationsDeletePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrganisationsDeletePanel_MouseDown);
            this.OrganisationsDeletePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrganisationsDeletePanel_MouseMove);
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
            // IdField
            // 
            this.IdField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdField.ForeColor = System.Drawing.Color.Gray;
            this.IdField.Location = new System.Drawing.Point(45, 81);
            this.IdField.Multiline = true;
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(298, 47);
            this.IdField.TabIndex = 74;
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
            this.EmailField.TabIndex = 73;
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
            this.PhoneField.TabIndex = 72;
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
            this.AddressField.TabIndex = 71;
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
            this.TypeField.TabIndex = 70;
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
            this.NameField.TabIndex = 69;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(75, 420);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(227, 60);
            this.DeleteButton.TabIndex = 68;
            this.DeleteButton.Text = "Видалити організацію";
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
            this.IdLabel.TabIndex = 67;
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
            // OrganisationsDeleteForm
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
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.OrganisationsDeletePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationsDeleteForm";
            this.Text = "Form9";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrganisationsDeleteForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrganisationsDeleteForm_MouseMove);
            this.OrganisationsDeletePanel.ResumeLayout(false);
            this.OrganisationsDeletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OrganisationsDeletePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox TypeField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}