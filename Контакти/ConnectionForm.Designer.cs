namespace Контакти
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConnectionFormPanel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdConnectionSearchField = new System.Windows.Forms.TextBox();
            this.IdContactSearchField = new System.Windows.Forms.TextBox();
            this.TypeConnectionSearchField = new System.Windows.Forms.TextBox();
            this.IdOrganizationSearchField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdOrganizationConnectionField = new System.Windows.Forms.TextBox();
            this.IdContactConnectionField = new System.Windows.Forms.TextBox();
            this.IdConnectionField = new System.Windows.Forms.TextBox();
            this.TypeConnectionField = new System.Windows.Forms.TextBox();
            this.IdOrganizationField = new System.Windows.Forms.TextBox();
            this.AddressOrganizationField = new System.Windows.Forms.TextBox();
            this.EmailOrganizationField = new System.Windows.Forms.TextBox();
            this.PhoneOrganizationField = new System.Windows.Forms.TextBox();
            this.TypeOrganizationField = new System.Windows.Forms.TextBox();
            this.NameOrganizationField = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.IdField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.BirthDateField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConnectionFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionFormPanel
            // 
            this.ConnectionFormPanel.BackColor = System.Drawing.Color.White;
            this.ConnectionFormPanel.Controls.Add(this.label1);
            this.ConnectionFormPanel.Controls.Add(this.pictureBox1);
            this.ConnectionFormPanel.Controls.Add(this.Minimize);
            this.ConnectionFormPanel.Controls.Add(this.Maximize);
            this.ConnectionFormPanel.Controls.Add(this.CloseButton);
            this.ConnectionFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectionFormPanel.Name = "ConnectionFormPanel";
            this.ConnectionFormPanel.Size = new System.Drawing.Size(1912, 45);
            this.ConnectionFormPanel.TabIndex = 10;
            this.ConnectionFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionFormPanel_MouseDown);
            this.ConnectionFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionFormPanel_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1769, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 26);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 32;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(1825, 9);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 26);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize.TabIndex = 32;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(1872, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 26);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(27, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1852, 378);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.MainButton);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.ChangeButton);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.UpdateButton);
            this.panel3.Location = new System.Drawing.Point(1442, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 309);
            this.panel3.TabIndex = 31;
            // 
            // MainButton
            // 
            this.MainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MainButton.BackColor = System.Drawing.Color.White;
            this.MainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MainButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(182, 247);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(240, 47);
            this.MainButton.TabIndex = 32;
            this.MainButton.Text = "Головна сторінка";
            this.MainButton.UseVisualStyleBackColor = false;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(16, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 34);
            this.label17.TabIndex = 31;
            this.label17.Text = "Функції :";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(182, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(240, 51);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Додати зв\'язок";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.BackColor = System.Drawing.Color.White;
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChangeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(182, 75);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(240, 51);
            this.ChangeButton.TabIndex = 10;
            this.ChangeButton.Text = "Змінити зв\'язок";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(182, 137);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(240, 47);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Видалити зв\'язок";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(182, 193);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(240, 47);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Оновити таблицю";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.IdConnectionSearchField);
            this.panel2.Controls.Add(this.IdContactSearchField);
            this.panel2.Controls.Add(this.TypeConnectionSearchField);
            this.panel2.Controls.Add(this.IdOrganizationSearchField);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1004, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 309);
            this.panel2.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(133, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 21);
            this.label12.TabIndex = 34;
            this.label12.Text = "Тип зв\'язку:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(38, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Ідентифікатор зв\'язку:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 21);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ідентифікатор організації:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ідентифікатор контакту:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 34);
            this.label8.TabIndex = 30;
            this.label8.Text = "Пошук :";
            // 
            // IdConnectionSearchField
            // 
            this.IdConnectionSearchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdConnectionSearchField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdConnectionSearchField.ForeColor = System.Drawing.Color.Black;
            this.IdConnectionSearchField.Location = new System.Drawing.Point(258, 110);
            this.IdConnectionSearchField.Multiline = true;
            this.IdConnectionSearchField.Name = "IdConnectionSearchField";
            this.IdConnectionSearchField.Size = new System.Drawing.Size(162, 29);
            this.IdConnectionSearchField.TabIndex = 21;
            this.IdConnectionSearchField.TextChanged += new System.EventHandler(this.IdConnectionSearchField_TextChanged);
            this.IdConnectionSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdConnectionSearchField_KeyPress);
            // 
            // IdContactSearchField
            // 
            this.IdContactSearchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdContactSearchField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdContactSearchField.ForeColor = System.Drawing.Color.Black;
            this.IdContactSearchField.Location = new System.Drawing.Point(258, 145);
            this.IdContactSearchField.Multiline = true;
            this.IdContactSearchField.Name = "IdContactSearchField";
            this.IdContactSearchField.Size = new System.Drawing.Size(162, 29);
            this.IdContactSearchField.TabIndex = 15;
            this.IdContactSearchField.TextChanged += new System.EventHandler(this.IdContactSearchField_TextChanged);
            this.IdContactSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdContactSearchField_KeyPress);
            // 
            // TypeConnectionSearchField
            // 
            this.TypeConnectionSearchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeConnectionSearchField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeConnectionSearchField.ForeColor = System.Drawing.Color.Black;
            this.TypeConnectionSearchField.Location = new System.Drawing.Point(258, 215);
            this.TypeConnectionSearchField.Multiline = true;
            this.TypeConnectionSearchField.Name = "TypeConnectionSearchField";
            this.TypeConnectionSearchField.Size = new System.Drawing.Size(162, 29);
            this.TypeConnectionSearchField.TabIndex = 17;
            this.TypeConnectionSearchField.TextChanged += new System.EventHandler(this.TypeConnectionSearchField_TextChanged);
            this.TypeConnectionSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeConnectionSearchField_KeyPress);
            // 
            // IdOrganizationSearchField
            // 
            this.IdOrganizationSearchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdOrganizationSearchField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOrganizationSearchField.ForeColor = System.Drawing.Color.Black;
            this.IdOrganizationSearchField.Location = new System.Drawing.Point(258, 180);
            this.IdOrganizationSearchField.Multiline = true;
            this.IdOrganizationSearchField.Name = "IdOrganizationSearchField";
            this.IdOrganizationSearchField.Size = new System.Drawing.Size(162, 29);
            this.IdOrganizationSearchField.TabIndex = 16;
            this.IdOrganizationSearchField.TextChanged += new System.EventHandler(this.IdOrganizationSearchField_TextChanged);
            this.IdOrganizationSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdOrganizationSearchField_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.IdOrganizationConnectionField);
            this.panel1.Controls.Add(this.IdContactConnectionField);
            this.panel1.Controls.Add(this.IdConnectionField);
            this.panel1.Controls.Add(this.TypeConnectionField);
            this.panel1.Controls.Add(this.IdOrganizationField);
            this.panel1.Controls.Add(this.AddressOrganizationField);
            this.panel1.Controls.Add(this.EmailOrganizationField);
            this.panel1.Controls.Add(this.PhoneOrganizationField);
            this.panel1.Controls.Add(this.TypeOrganizationField);
            this.panel1.Controls.Add(this.NameOrganizationField);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.IdField);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.BirthDateField);
            this.panel1.Controls.Add(this.PhoneField);
            this.panel1.Controls.Add(this.AddressField);
            this.panel1.Controls.Add(this.SurnameField);
            this.panel1.Controls.Add(this.EmailField);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(27, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 309);
            this.panel1.TabIndex = 32;
            // 
            // IdOrganizationConnectionField
            // 
            this.IdOrganizationConnectionField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOrganizationConnectionField.ForeColor = System.Drawing.Color.Black;
            this.IdOrganizationConnectionField.Location = new System.Drawing.Point(807, 179);
            this.IdOrganizationConnectionField.Multiline = true;
            this.IdOrganizationConnectionField.Name = "IdOrganizationConnectionField";
            this.IdOrganizationConnectionField.ReadOnly = true;
            this.IdOrganizationConnectionField.Size = new System.Drawing.Size(126, 30);
            this.IdOrganizationConnectionField.TabIndex = 45;
            // 
            // IdContactConnectionField
            // 
            this.IdContactConnectionField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdContactConnectionField.ForeColor = System.Drawing.Color.Black;
            this.IdContactConnectionField.Location = new System.Drawing.Point(807, 144);
            this.IdContactConnectionField.Multiline = true;
            this.IdContactConnectionField.Name = "IdContactConnectionField";
            this.IdContactConnectionField.ReadOnly = true;
            this.IdContactConnectionField.Size = new System.Drawing.Size(126, 30);
            this.IdContactConnectionField.TabIndex = 44;
            // 
            // IdConnectionField
            // 
            this.IdConnectionField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdConnectionField.ForeColor = System.Drawing.Color.Black;
            this.IdConnectionField.Location = new System.Drawing.Point(807, 110);
            this.IdConnectionField.Multiline = true;
            this.IdConnectionField.Name = "IdConnectionField";
            this.IdConnectionField.ReadOnly = true;
            this.IdConnectionField.Size = new System.Drawing.Size(126, 30);
            this.IdConnectionField.TabIndex = 43;
            // 
            // TypeConnectionField
            // 
            this.TypeConnectionField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeConnectionField.ForeColor = System.Drawing.Color.Black;
            this.TypeConnectionField.Location = new System.Drawing.Point(807, 214);
            this.TypeConnectionField.Multiline = true;
            this.TypeConnectionField.Name = "TypeConnectionField";
            this.TypeConnectionField.ReadOnly = true;
            this.TypeConnectionField.Size = new System.Drawing.Size(126, 30);
            this.TypeConnectionField.TabIndex = 31;
            // 
            // IdOrganizationField
            // 
            this.IdOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.IdOrganizationField.Location = new System.Drawing.Point(481, 74);
            this.IdOrganizationField.Multiline = true;
            this.IdOrganizationField.Name = "IdOrganizationField";
            this.IdOrganizationField.ReadOnly = true;
            this.IdOrganizationField.Size = new System.Drawing.Size(298, 30);
            this.IdOrganizationField.TabIndex = 42;
            // 
            // AddressOrganizationField
            // 
            this.AddressOrganizationField.BackColor = System.Drawing.SystemColors.Window;
            this.AddressOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.AddressOrganizationField.Location = new System.Drawing.Point(481, 179);
            this.AddressOrganizationField.Multiline = true;
            this.AddressOrganizationField.Name = "AddressOrganizationField";
            this.AddressOrganizationField.ReadOnly = true;
            this.AddressOrganizationField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressOrganizationField.Size = new System.Drawing.Size(298, 30);
            this.AddressOrganizationField.TabIndex = 41;
            // 
            // EmailOrganizationField
            // 
            this.EmailOrganizationField.BackColor = System.Drawing.SystemColors.Window;
            this.EmailOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.EmailOrganizationField.Location = new System.Drawing.Point(481, 249);
            this.EmailOrganizationField.Multiline = true;
            this.EmailOrganizationField.Name = "EmailOrganizationField";
            this.EmailOrganizationField.ReadOnly = true;
            this.EmailOrganizationField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmailOrganizationField.Size = new System.Drawing.Size(298, 29);
            this.EmailOrganizationField.TabIndex = 40;
            // 
            // PhoneOrganizationField
            // 
            this.PhoneOrganizationField.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.PhoneOrganizationField.Location = new System.Drawing.Point(481, 214);
            this.PhoneOrganizationField.Multiline = true;
            this.PhoneOrganizationField.Name = "PhoneOrganizationField";
            this.PhoneOrganizationField.ReadOnly = true;
            this.PhoneOrganizationField.Size = new System.Drawing.Size(298, 30);
            this.PhoneOrganizationField.TabIndex = 39;
            // 
            // TypeOrganizationField
            // 
            this.TypeOrganizationField.BackColor = System.Drawing.SystemColors.Window;
            this.TypeOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.TypeOrganizationField.Location = new System.Drawing.Point(481, 144);
            this.TypeOrganizationField.Multiline = true;
            this.TypeOrganizationField.Name = "TypeOrganizationField";
            this.TypeOrganizationField.ReadOnly = true;
            this.TypeOrganizationField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TypeOrganizationField.Size = new System.Drawing.Size(298, 30);
            this.TypeOrganizationField.TabIndex = 38;
            // 
            // NameOrganizationField
            // 
            this.NameOrganizationField.BackColor = System.Drawing.SystemColors.Window;
            this.NameOrganizationField.Font = new System.Drawing.Font("Lato", 10.2F);
            this.NameOrganizationField.Location = new System.Drawing.Point(481, 110);
            this.NameOrganizationField.Multiline = true;
            this.NameOrganizationField.Name = "NameOrganizationField";
            this.NameOrganizationField.ReadOnly = true;
            this.NameOrganizationField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameOrganizationField.Size = new System.Drawing.Size(298, 30);
            this.NameOrganizationField.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(24, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 34);
            this.label16.TabIndex = 30;
            this.label16.Text = "Запис :";
            // 
            // IdField
            // 
            this.IdField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdField.ForeColor = System.Drawing.Color.Gray;
            this.IdField.Location = new System.Drawing.Point(148, 55);
            this.IdField.Multiline = true;
            this.IdField.Name = "IdField";
            this.IdField.ReadOnly = true;
            this.IdField.Size = new System.Drawing.Size(298, 29);
            this.IdField.TabIndex = 21;
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.Gray;
            this.NameField.Location = new System.Drawing.Point(148, 90);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(298, 29);
            this.NameField.TabIndex = 15;
            // 
            // BirthDateField
            // 
            this.BirthDateField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateField.ForeColor = System.Drawing.Color.Gray;
            this.BirthDateField.Location = new System.Drawing.Point(148, 265);
            this.BirthDateField.Multiline = true;
            this.BirthDateField.Name = "BirthDateField";
            this.BirthDateField.ReadOnly = true;
            this.BirthDateField.Size = new System.Drawing.Size(298, 29);
            this.BirthDateField.TabIndex = 20;
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.ForeColor = System.Drawing.Color.Gray;
            this.PhoneField.Location = new System.Drawing.Point(148, 160);
            this.PhoneField.Multiline = true;
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(298, 29);
            this.PhoneField.TabIndex = 17;
            // 
            // AddressField
            // 
            this.AddressField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressField.ForeColor = System.Drawing.Color.Gray;
            this.AddressField.Location = new System.Drawing.Point(148, 230);
            this.AddressField.Multiline = true;
            this.AddressField.Name = "AddressField";
            this.AddressField.ReadOnly = true;
            this.AddressField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressField.Size = new System.Drawing.Size(298, 29);
            this.AddressField.TabIndex = 19;
            // 
            // SurnameField
            // 
            this.SurnameField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameField.ForeColor = System.Drawing.Color.Gray;
            this.SurnameField.Location = new System.Drawing.Point(148, 125);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.ReadOnly = true;
            this.SurnameField.Size = new System.Drawing.Size(298, 29);
            this.SurnameField.TabIndex = 16;
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.Gray;
            this.EmailField.Location = new System.Drawing.Point(148, 195);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmailField.Size = new System.Drawing.Size(298, 29);
            this.EmailField.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Notebook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Контакти.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1912, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConnectionFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ConnectionForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectionForm_MouseMove);
            this.ConnectionFormPanel.ResumeLayout(false);
            this.ConnectionFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionFormPanel;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdConnectionSearchField;
        private System.Windows.Forms.TextBox IdContactSearchField;
        private System.Windows.Forms.TextBox TypeConnectionSearchField;
        private System.Windows.Forms.TextBox IdOrganizationSearchField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TypeConnectionField;
        private System.Windows.Forms.TextBox IdOrganizationField;
        private System.Windows.Forms.TextBox AddressOrganizationField;
        private System.Windows.Forms.TextBox EmailOrganizationField;
        private System.Windows.Forms.TextBox PhoneOrganizationField;
        private System.Windows.Forms.TextBox TypeOrganizationField;
        private System.Windows.Forms.TextBox NameOrganizationField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IdField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox BirthDateField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox IdOrganizationConnectionField;
        private System.Windows.Forms.TextBox IdContactConnectionField;
        private System.Windows.Forms.TextBox IdConnectionField;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}