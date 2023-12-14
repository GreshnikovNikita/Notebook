namespace Контакти
{
    partial class ConnectionChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionChangeForm));
            this.ConnectionChangePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.TypeConnectionLabel = new System.Windows.Forms.Label();
            this.IdOrganizationLabel = new System.Windows.Forms.Label();
            this.IdContactLabel = new System.Windows.Forms.Label();
            this.TypeConnectionField = new System.Windows.Forms.TextBox();
            this.IdOrganizationField = new System.Windows.Forms.TextBox();
            this.IdContactField = new System.Windows.Forms.TextBox();
            this.IdConnectionField = new System.Windows.Forms.TextBox();
            this.IdConnectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConnectionChangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionChangePanel
            // 
            this.ConnectionChangePanel.BackColor = System.Drawing.Color.White;
            this.ConnectionChangePanel.Controls.Add(this.label1);
            this.ConnectionChangePanel.Controls.Add(this.pictureBox1);
            this.ConnectionChangePanel.Controls.Add(this.CloseButton);
            this.ConnectionChangePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionChangePanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionChangePanel.Name = "ConnectionChangePanel";
            this.ConnectionChangePanel.Size = new System.Drawing.Size(390, 44);
            this.ConnectionChangePanel.TabIndex = 27;
            this.ConnectionChangePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionChangePanel_MouseDown);
            this.ConnectionChangePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionChangePanel_MouseMove);
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
            this.ChangeButton.BackColor = System.Drawing.Color.White;
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(75, 315);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(227, 60);
            this.ChangeButton.TabIndex = 28;
            this.ChangeButton.Text = "Змінити зв\'язок";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // TypeConnectionLabel
            // 
            this.TypeConnectionLabel.AutoSize = true;
            this.TypeConnectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeConnectionLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeConnectionLabel.ForeColor = System.Drawing.Color.White;
            this.TypeConnectionLabel.Location = new System.Drawing.Point(349, 229);
            this.TypeConnectionLabel.Name = "TypeConnectionLabel";
            this.TypeConnectionLabel.Size = new System.Drawing.Size(33, 45);
            this.TypeConnectionLabel.TabIndex = 38;
            this.TypeConnectionLabel.Text = "!";
            this.TypeConnectionLabel.Click += new System.EventHandler(this.TypeConnectionLabel_Click);
            // 
            // IdOrganizationLabel
            // 
            this.IdOrganizationLabel.AutoSize = true;
            this.IdOrganizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdOrganizationLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOrganizationLabel.ForeColor = System.Drawing.Color.White;
            this.IdOrganizationLabel.Location = new System.Drawing.Point(349, 178);
            this.IdOrganizationLabel.Name = "IdOrganizationLabel";
            this.IdOrganizationLabel.Size = new System.Drawing.Size(33, 45);
            this.IdOrganizationLabel.TabIndex = 37;
            this.IdOrganizationLabel.Text = "!";
            this.IdOrganizationLabel.Click += new System.EventHandler(this.IdOrganizationLabel_Click);
            // 
            // IdContactLabel
            // 
            this.IdContactLabel.AutoSize = true;
            this.IdContactLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdContactLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdContactLabel.ForeColor = System.Drawing.Color.White;
            this.IdContactLabel.Location = new System.Drawing.Point(349, 125);
            this.IdContactLabel.Name = "IdContactLabel";
            this.IdContactLabel.Size = new System.Drawing.Size(33, 45);
            this.IdContactLabel.TabIndex = 36;
            this.IdContactLabel.Text = "!";
            this.IdContactLabel.Click += new System.EventHandler(this.IdContactLabel_Click);
            // 
            // TypeConnectionField
            // 
            this.TypeConnectionField.BackColor = System.Drawing.Color.White;
            this.TypeConnectionField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.TypeConnectionField.ForeColor = System.Drawing.Color.White;
            this.TypeConnectionField.Location = new System.Drawing.Point(36, 229);
            this.TypeConnectionField.Multiline = true;
            this.TypeConnectionField.Name = "TypeConnectionField";
            this.TypeConnectionField.ReadOnly = true;
            this.TypeConnectionField.Size = new System.Drawing.Size(307, 47);
            this.TypeConnectionField.TabIndex = 35;
            this.TypeConnectionField.Enter += new System.EventHandler(this.TypeConnectionField_Enter);
            this.TypeConnectionField.Leave += new System.EventHandler(this.TypeConnectionField_Leave);
            // 
            // IdOrganizationField
            // 
            this.IdOrganizationField.BackColor = System.Drawing.Color.White;
            this.IdOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdOrganizationField.ForeColor = System.Drawing.Color.White;
            this.IdOrganizationField.Location = new System.Drawing.Point(36, 176);
            this.IdOrganizationField.Multiline = true;
            this.IdOrganizationField.Name = "IdOrganizationField";
            this.IdOrganizationField.ReadOnly = true;
            this.IdOrganizationField.Size = new System.Drawing.Size(307, 47);
            this.IdOrganizationField.TabIndex = 34;
            this.IdOrganizationField.Enter += new System.EventHandler(this.IdOrganizationField_Enter);
            this.IdOrganizationField.Leave += new System.EventHandler(this.IdOrganizationField_Leave);
            // 
            // IdContactField
            // 
            this.IdContactField.BackColor = System.Drawing.Color.White;
            this.IdContactField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdContactField.ForeColor = System.Drawing.Color.White;
            this.IdContactField.Location = new System.Drawing.Point(36, 123);
            this.IdContactField.Multiline = true;
            this.IdContactField.Name = "IdContactField";
            this.IdContactField.ReadOnly = true;
            this.IdContactField.Size = new System.Drawing.Size(307, 47);
            this.IdContactField.TabIndex = 33;
            this.IdContactField.Enter += new System.EventHandler(this.IdContactField_Enter);
            this.IdContactField.Leave += new System.EventHandler(this.IdContactField_Leave);
            // 
            // IdConnectionField
            // 
            this.IdConnectionField.BackColor = System.Drawing.Color.White;
            this.IdConnectionField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdConnectionField.ForeColor = System.Drawing.Color.Gray;
            this.IdConnectionField.Location = new System.Drawing.Point(36, 70);
            this.IdConnectionField.Multiline = true;
            this.IdConnectionField.Name = "IdConnectionField";
            this.IdConnectionField.Size = new System.Drawing.Size(307, 47);
            this.IdConnectionField.TabIndex = 39;
            this.IdConnectionField.Text = "Введіть ідентифікатор зв\'язку";
            this.IdConnectionField.Enter += new System.EventHandler(this.IdConnectionField_Enter);
            this.IdConnectionField.Leave += new System.EventHandler(this.IdConnectionField_Leave);
            // 
            // IdConnectionLabel
            // 
            this.IdConnectionLabel.AutoSize = true;
            this.IdConnectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdConnectionLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdConnectionLabel.ForeColor = System.Drawing.Color.White;
            this.IdConnectionLabel.Location = new System.Drawing.Point(349, 72);
            this.IdConnectionLabel.Name = "IdConnectionLabel";
            this.IdConnectionLabel.Size = new System.Drawing.Size(33, 45);
            this.IdConnectionLabel.TabIndex = 40;
            this.IdConnectionLabel.Text = "!";
            this.IdConnectionLabel.Click += new System.EventHandler(this.IdConnectionLabel_Click);
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
            // ConnectionChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 419);
            this.Controls.Add(this.IdConnectionLabel);
            this.Controls.Add(this.IdConnectionField);
            this.Controls.Add(this.TypeConnectionLabel);
            this.Controls.Add(this.IdOrganizationLabel);
            this.Controls.Add(this.IdContactLabel);
            this.Controls.Add(this.TypeConnectionField);
            this.Controls.Add(this.IdOrganizationField);
            this.Controls.Add(this.IdContactField);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ConnectionChangePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionChangeForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionChangeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionChangeForm_MouseMove);
            this.ConnectionChangePanel.ResumeLayout(false);
            this.ConnectionChangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionChangePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label TypeConnectionLabel;
        private System.Windows.Forms.Label IdOrganizationLabel;
        private System.Windows.Forms.Label IdContactLabel;
        private System.Windows.Forms.TextBox TypeConnectionField;
        private System.Windows.Forms.TextBox IdOrganizationField;
        private System.Windows.Forms.TextBox IdContactField;
        private System.Windows.Forms.TextBox IdConnectionField;
        private System.Windows.Forms.Label IdConnectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}