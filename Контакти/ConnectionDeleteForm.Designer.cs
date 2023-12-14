namespace Контакти
{
    partial class ConnectionDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDeleteForm));
            this.ConnectionDeletePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdConnectionLabel = new System.Windows.Forms.Label();
            this.IdConnectionField = new System.Windows.Forms.TextBox();
            this.TypeConnectionField = new System.Windows.Forms.TextBox();
            this.IdOrganizationField = new System.Windows.Forms.TextBox();
            this.IdContactField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConnectionDeletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionDeletePanel
            // 
            this.ConnectionDeletePanel.BackColor = System.Drawing.Color.White;
            this.ConnectionDeletePanel.Controls.Add(this.label1);
            this.ConnectionDeletePanel.Controls.Add(this.pictureBox1);
            this.ConnectionDeletePanel.Controls.Add(this.CloseButton);
            this.ConnectionDeletePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionDeletePanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionDeletePanel.Name = "ConnectionDeletePanel";
            this.ConnectionDeletePanel.Size = new System.Drawing.Size(390, 44);
            this.ConnectionDeletePanel.TabIndex = 28;
            this.ConnectionDeletePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionDeletePanel_MouseDown);
            this.ConnectionDeletePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionDeletePanel_MouseMove);
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
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(75, 315);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(227, 60);
            this.DeleteButton.TabIndex = 29;
            this.DeleteButton.Text = "Видалити зв\'язок";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.IdConnectionLabel.TabIndex = 48;
            this.IdConnectionLabel.Text = "!";
            this.IdConnectionLabel.Click += new System.EventHandler(this.IdConnectionLabel_Click);
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
            this.IdConnectionField.TabIndex = 47;
            this.IdConnectionField.Text = "Введіть ідентифікатор зв\'язку";
            this.IdConnectionField.Enter += new System.EventHandler(this.IdConnectionField_Enter);
            this.IdConnectionField.Leave += new System.EventHandler(this.IdConnectionField_Leave);
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
            this.TypeConnectionField.TabIndex = 43;
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
            this.IdOrganizationField.TabIndex = 42;
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
            this.IdContactField.TabIndex = 41;
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
            // ConnectionDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(390, 419);
            this.Controls.Add(this.IdConnectionLabel);
            this.Controls.Add(this.IdConnectionField);
            this.Controls.Add(this.TypeConnectionField);
            this.Controls.Add(this.IdOrganizationField);
            this.Controls.Add(this.IdContactField);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ConnectionDeletePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionDeleteForm";
            this.Text = "ConnectionDeleteForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionDeleteForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionDeleteForm_MouseMove);
            this.ConnectionDeletePanel.ResumeLayout(false);
            this.ConnectionDeletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionDeletePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label IdConnectionLabel;
        private System.Windows.Forms.TextBox IdConnectionField;
        private System.Windows.Forms.TextBox TypeConnectionField;
        private System.Windows.Forms.TextBox IdOrganizationField;
        private System.Windows.Forms.TextBox IdContactField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}