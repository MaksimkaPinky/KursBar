namespace KursBar
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label iD_OfficeLabel;
            System.Windows.Forms.Label дата_РожденияLabel;
            System.Windows.Forms.Label рольLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            System.Windows.Forms.Label логинLabel1;
            System.Windows.Forms.Label парольLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButRegistration = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_РожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.рольComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passBox = new System.Windows.Forms.TextBox();
            this.autorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            почтаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            дата_РожденияLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            логинLabel1 = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(469, 126);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(78, 25);
            почтаLabel.TabIndex = 9;
            почтаLabel.Text = "Почта:";
            почтаLabel.UseWaitCursor = true;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(469, 274);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(67, 25);
            фИОLabel.TabIndex = 13;
            фИОLabel.Text = "ФИО:";
            фИОLabel.UseWaitCursor = true;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(469, 352);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(57, 25);
            полLabel.TabIndex = 14;
            полLabel.Text = "Пол:";
            полLabel.UseWaitCursor = true;
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(20, 129);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(100, 25);
            iD_OfficeLabel.TabIndex = 15;
            iD_OfficeLabel.Text = "ID Office:";
            iD_OfficeLabel.UseWaitCursor = true;
            // 
            // дата_РожденияLabel
            // 
            дата_РожденияLabel.AutoSize = true;
            дата_РожденияLabel.Location = new System.Drawing.Point(20, 357);
            дата_РожденияLabel.Name = "дата_РожденияLabel";
            дата_РожденияLabel.Size = new System.Drawing.Size(174, 25);
            дата_РожденияLabel.TabIndex = 16;
            дата_РожденияLabel.Text = "Дата Рождения:";
            дата_РожденияLabel.UseWaitCursor = true;
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(469, 203);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(67, 25);
            рольLabel.TabIndex = 17;
            рольLabel.Text = "Роль:";
            рольLabel.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 304);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(207, 25);
            label2.TabIndex = 19;
            label2.Text = "Повторите пароль: ";
            label2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 100);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация ";
            this.label1.UseWaitCursor = true;
            // 
            // ButRegistration
            // 
            this.ButRegistration.BackColor = System.Drawing.Color.Blue;
            this.ButRegistration.ForeColor = System.Drawing.Color.White;
            this.ButRegistration.Location = new System.Drawing.Point(292, 436);
            this.ButRegistration.Name = "ButRegistration";
            this.ButRegistration.Size = new System.Drawing.Size(213, 51);
            this.ButRegistration.TabIndex = 1;
            this.ButRegistration.Text = "Зарегистрировать";
            this.ButRegistration.UseVisualStyleBackColor = false;
            this.ButRegistration.UseWaitCursor = true;
            this.ButRegistration.Click += new System.EventHandler(this.ButRegistration_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(KursBar.EF.User);
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(649, 123);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(201, 31);
            this.почтаTextBox.TabIndex = 10;
            this.почтаTextBox.UseWaitCursor = true;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(649, 271);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(201, 31);
            this.фИОTextBox.TabIndex = 14;
            this.фИОTextBox.UseWaitCursor = true;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пол", true));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.полComboBox.Location = new System.Drawing.Point(649, 349);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 33);
            this.полComboBox.TabIndex = 15;
            this.полComboBox.UseWaitCursor = true;
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.officeBindingSource, "ID", true));
            this.iD_OfficeComboBox.DataSource = this.officeBindingSource;
            this.iD_OfficeComboBox.DisplayMember = "Название_отдела";
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(254, 121);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(121, 33);
            this.iD_OfficeComboBox.TabIndex = 16;
            this.iD_OfficeComboBox.UseWaitCursor = true;
            this.iD_OfficeComboBox.ValueMember = "ID";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(KursBar.EF.Office);
            // 
            // дата_РожденияDateTimePicker
            // 
            this.дата_РожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Дата_Рождения", true));
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(227, 352);
            this.дата_РожденияDateTimePicker.MaxDate = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.дата_РожденияDateTimePicker.TabIndex = 17;
            this.дата_РожденияDateTimePicker.UseWaitCursor = true;
            this.дата_РожденияDateTimePicker.Value = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            // 
            // рольComboBox
            // 
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Роль", true));
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roleBindingSource, "ID", true));
            this.рольComboBox.DataSource = this.roleBindingSource;
            this.рольComboBox.DisplayMember = "Роль";
            this.рольComboBox.FormattingEnabled = true;
            this.рольComboBox.Location = new System.Drawing.Point(649, 200);
            this.рольComboBox.Name = "рольComboBox";
            this.рольComboBox.Size = new System.Drawing.Size(201, 33);
            this.рольComboBox.TabIndex = 18;
            this.рольComboBox.UseWaitCursor = true;
            this.рольComboBox.ValueMember = "ID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(KursBar.EF.Role);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(254, 301);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(121, 31);
            this.passBox.TabIndex = 20;
            this.passBox.UseWaitCursor = true;
            // 
            // autorizationBindingSource
            // 
            this.autorizationBindingSource.DataSource = typeof(KursBar.EF.Autorization);
            // 
            // логинLabel1
            // 
            логинLabel1.AutoSize = true;
            логинLabel1.Location = new System.Drawing.Point(20, 199);
            логинLabel1.Name = "логинLabel1";
            логинLabel1.Size = new System.Drawing.Size(77, 25);
            логинLabel1.TabIndex = 21;
            логинLabel1.Text = "Логин:";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizationBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(275, 196);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(100, 31);
            this.логинTextBox.TabIndex = 22;
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(20, 250);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(92, 25);
            парольLabel.TabIndex = 22;
            парольLabel.Text = "Пароль:";
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizationBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(275, 247);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(100, 31);
            this.парольTextBox.TabIndex = 23;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 541);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(логинLabel1);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольComboBox);
            this.Controls.Add(дата_РожденияLabel);
            this.Controls.Add(this.дата_РожденияDateTimePicker);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.ButRegistration);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registration";
            this.Text = "Форма регистрации ";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.ComboBox iD_OfficeComboBox;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.DateTimePicker дата_РожденияDateTimePicker;
        private System.Windows.Forms.ComboBox рольComboBox;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.BindingSource autorizationBindingSource;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
    }
}