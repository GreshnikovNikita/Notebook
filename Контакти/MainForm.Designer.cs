namespace Контакти
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenContactsForm = new System.Windows.Forms.Button();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InformationBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.OpenOrganizationsForm = new System.Windows.Forms.Button();
            this.OpenConnectionsForm = new System.Windows.Forms.Button();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenContactsForm
            // 
            this.OpenContactsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenContactsForm.BackColor = System.Drawing.Color.White;
            this.OpenContactsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenContactsForm.FlatAppearance.BorderSize = 0;
            this.OpenContactsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.OpenContactsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.OpenContactsForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenContactsForm.Location = new System.Drawing.Point(65, 169);
            this.OpenContactsForm.Name = "OpenContactsForm";
            this.OpenContactsForm.Size = new System.Drawing.Size(264, 71);
            this.OpenContactsForm.TabIndex = 13;
            this.OpenContactsForm.Text = "Відкрити таблицю контактів";
            this.OpenContactsForm.UseVisualStyleBackColor = false;
            this.OpenContactsForm.Click += new System.EventHandler(this.OpenContactsForm_Click);
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.BackColor = System.Drawing.Color.White;
            this.MainFormPanel.Controls.Add(this.label1);
            this.MainFormPanel.Controls.Add(this.InformationBox);
            this.MainFormPanel.Controls.Add(this.pictureBox1);
            this.MainFormPanel.Controls.Add(this.CloseButton);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(400, 44);
            this.MainFormPanel.TabIndex = 17;
            this.MainFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseDown);
            this.MainFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseMove);
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
            // InformationBox
            // 
            this.InformationBox.BackColor = System.Drawing.Color.White;
            this.InformationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InformationBox.Image = global::Контакти.Properties.Resources.information1;
            this.InformationBox.Location = new System.Drawing.Point(311, 9);
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(34, 28);
            this.InformationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InformationBox.TabIndex = 20;
            this.InformationBox.TabStop = false;
            this.InformationBox.Click += new System.EventHandler(this.InformationBox_Click);
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
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(360, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 26);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenOrganizationsForm
            // 
            this.OpenOrganizationsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenOrganizationsForm.BackColor = System.Drawing.Color.White;
            this.OpenOrganizationsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenOrganizationsForm.FlatAppearance.BorderSize = 0;
            this.OpenOrganizationsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.OpenOrganizationsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.OpenOrganizationsForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenOrganizationsForm.Location = new System.Drawing.Point(65, 270);
            this.OpenOrganizationsForm.Name = "OpenOrganizationsForm";
            this.OpenOrganizationsForm.Size = new System.Drawing.Size(264, 71);
            this.OpenOrganizationsForm.TabIndex = 18;
            this.OpenOrganizationsForm.Text = "Відкрити таблицю організацій";
            this.OpenOrganizationsForm.UseVisualStyleBackColor = false;
            this.OpenOrganizationsForm.Click += new System.EventHandler(this.OpenOrganizationsForm_Click);
            // 
            // OpenConnectionsForm
            // 
            this.OpenConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenConnectionsForm.BackColor = System.Drawing.Color.White;
            this.OpenConnectionsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenConnectionsForm.FlatAppearance.BorderSize = 0;
            this.OpenConnectionsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.OpenConnectionsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.OpenConnectionsForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenConnectionsForm.Location = new System.Drawing.Point(65, 371);
            this.OpenConnectionsForm.Name = "OpenConnectionsForm";
            this.OpenConnectionsForm.Size = new System.Drawing.Size(264, 71);
            this.OpenConnectionsForm.TabIndex = 19;
            this.OpenConnectionsForm.Text = "Відкрити таблицю зв\'язків";
            this.OpenConnectionsForm.UseVisualStyleBackColor = false;
            this.OpenConnectionsForm.Click += new System.EventHandler(this.OpenConnectionsForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.OpenConnectionsForm);
            this.Controls.Add(this.OpenOrganizationsForm);
            this.Controls.Add(this.MainFormPanel);
            this.Controls.Add(this.OpenContactsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MainFormPanel.ResumeLayout(false);
            this.MainFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenContactsForm;
        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button OpenOrganizationsForm;
        private System.Windows.Forms.Button OpenConnectionsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox InformationBox;
    }
}