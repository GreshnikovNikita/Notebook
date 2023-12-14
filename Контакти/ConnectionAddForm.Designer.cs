namespace Контакти
{
    partial class ConnectionAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionAddForm));
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.IdContactField = new System.Windows.Forms.TextBox();
            this.IdOrganizationField = new System.Windows.Forms.TextBox();
            this.TypeConnectionField = new System.Windows.Forms.TextBox();
            this.IdContactLabel = new System.Windows.Forms.Label();
            this.IdOrganizationLabel = new System.Windows.Forms.Label();
            this.TypeConnectionLabel = new System.Windows.Forms.Label();
            this.ConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.BackColor = System.Drawing.Color.White;
            this.ConnectionPanel.Controls.Add(this.label1);
            this.ConnectionPanel.Controls.Add(this.CloseButton);
            this.ConnectionPanel.Controls.Add(this.pictureBox1);
            this.ConnectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionPanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(390, 44);
            this.ConnectionPanel.TabIndex = 19;
            this.ConnectionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionPanel_MouseDown);
            this.ConnectionPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Notebook";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Контакти.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(75, 261);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(227, 60);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Додати зв\'язок";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IdContactField
            // 
            this.IdContactField.BackColor = System.Drawing.Color.White;
            this.IdContactField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdContactField.ForeColor = System.Drawing.Color.Gray;
            this.IdContactField.Location = new System.Drawing.Point(36, 70);
            this.IdContactField.Multiline = true;
            this.IdContactField.Name = "IdContactField";
            this.IdContactField.Size = new System.Drawing.Size(307, 47);
            this.IdContactField.TabIndex = 21;
            this.IdContactField.Text = "Введіть ідентифікатор контакту";
            this.IdContactField.Enter += new System.EventHandler(this.IdContactField_Enter);
            this.IdContactField.Leave += new System.EventHandler(this.IdContactField_Leave);
            // 
            // IdOrganizationField
            // 
            this.IdOrganizationField.BackColor = System.Drawing.Color.White;
            this.IdOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdOrganizationField.ForeColor = System.Drawing.Color.Gray;
            this.IdOrganizationField.Location = new System.Drawing.Point(36, 123);
            this.IdOrganizationField.Multiline = true;
            this.IdOrganizationField.Name = "IdOrganizationField";
            this.IdOrganizationField.Size = new System.Drawing.Size(307, 47);
            this.IdOrganizationField.TabIndex = 22;
            this.IdOrganizationField.Text = "Введіть ідентифікатор організації";
            this.IdOrganizationField.Enter += new System.EventHandler(this.IdOrganizationField_Enter);
            this.IdOrganizationField.Leave += new System.EventHandler(this.IdOrganizationField_Leave);
            // 
            // TypeConnectionField
            // 
            this.TypeConnectionField.BackColor = System.Drawing.Color.White;
            this.TypeConnectionField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.TypeConnectionField.ForeColor = System.Drawing.Color.Gray;
            this.TypeConnectionField.Location = new System.Drawing.Point(36, 176);
            this.TypeConnectionField.Multiline = true;
            this.TypeConnectionField.Name = "TypeConnectionField";
            this.TypeConnectionField.Size = new System.Drawing.Size(307, 47);
            this.TypeConnectionField.TabIndex = 23;
            this.TypeConnectionField.Text = "Введіть тип зв\'язку";
            this.TypeConnectionField.Enter += new System.EventHandler(this.TypeConnectionField_Enter);
            this.TypeConnectionField.Leave += new System.EventHandler(this.TypeConnectionField_Leave);
            // 
            // IdContactLabel
            // 
            this.IdContactLabel.AutoSize = true;
            this.IdContactLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdContactLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdContactLabel.ForeColor = System.Drawing.Color.White;
            this.IdContactLabel.Location = new System.Drawing.Point(349, 72);
            this.IdContactLabel.Name = "IdContactLabel";
            this.IdContactLabel.Size = new System.Drawing.Size(33, 45);
            this.IdContactLabel.TabIndex = 30;
            this.IdContactLabel.Text = "!";
            this.IdContactLabel.Click += new System.EventHandler(this.IdContactLabel_Click);
            // 
            // IdOrganizationLabel
            // 
            this.IdOrganizationLabel.AutoSize = true;
            this.IdOrganizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdOrganizationLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOrganizationLabel.ForeColor = System.Drawing.Color.White;
            this.IdOrganizationLabel.Location = new System.Drawing.Point(349, 125);
            this.IdOrganizationLabel.Name = "IdOrganizationLabel";
            this.IdOrganizationLabel.Size = new System.Drawing.Size(33, 45);
            this.IdOrganizationLabel.TabIndex = 31;
            this.IdOrganizationLabel.Text = "!";
            this.IdOrganizationLabel.Click += new System.EventHandler(this.IdOrganizationLabel_Click);
            // 
            // TypeConnectionLabel
            // 
            this.TypeConnectionLabel.AutoSize = true;
            this.TypeConnectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeConnectionLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeConnectionLabel.ForeColor = System.Drawing.Color.White;
            this.TypeConnectionLabel.Location = new System.Drawing.Point(349, 178);
            this.TypeConnectionLabel.Name = "TypeConnectionLabel";
            this.TypeConnectionLabel.Size = new System.Drawing.Size(33, 45);
            this.TypeConnectionLabel.TabIndex = 32;
            this.TypeConnectionLabel.Text = "!";
            this.TypeConnectionLabel.Click += new System.EventHandler(this.TypeConnectionLabel_Click);
            // 
            // ConnectionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 363);
            this.Controls.Add(this.TypeConnectionLabel);
            this.Controls.Add(this.IdOrganizationLabel);
            this.Controls.Add(this.IdContactLabel);
            this.Controls.Add(this.TypeConnectionField);
            this.Controls.Add(this.IdOrganizationField);
            this.Controls.Add(this.IdContactField);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ConnectionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionAddForm";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionAddForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionAddForm_MouseMove);
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox IdContactField;
        private System.Windows.Forms.TextBox IdOrganizationField;
        private System.Windows.Forms.TextBox TypeConnectionField;
        private System.Windows.Forms.Label IdContactLabel;
        private System.Windows.Forms.Label IdOrganizationLabel;
        private System.Windows.Forms.Label TypeConnectionLabel;
        private System.Windows.Forms.Label label1;
    }
}