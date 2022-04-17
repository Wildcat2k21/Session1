
namespace LearnSchool
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nazvanieLabel = new System.Windows.Forms.Label();
            this.stoimostText = new System.Windows.Forms.TextBox();
            this.stoimostLabel = new System.Windows.Forms.Label();
            this.dlitelnostText = new System.Windows.Forms.TextBox();
            this.dlitelnostLabel = new System.Windows.Forms.Label();
            this.opisanieText = new System.Windows.Forms.TextBox();
            this.opisanieLabel = new System.Windows.Forms.Label();
            this.skidkaText = new System.Windows.Forms.TextBox();
            this.skidkaLabel = new System.Windows.Forms.Label();
            this.kartinkaUslugi = new System.Windows.Forms.PictureBox();
            this.kartinkaText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet5 = new LearnSchool.SchoolDataSet5();
            this.schoolDataSet4 = new LearnSchool.SchoolDataSet4();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new LearnSchool.SchoolDataSet4TableAdapters.ServiceTableAdapter();
            this.serviceTableAdapter1 = new LearnSchool.SchoolDataSet5TableAdapters.ServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinkaUslugi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(14, 14);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 27);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearnSchool.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 591);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(24, 58);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(317, 23);
            this.nameText.TabIndex = 2;
            // 
            // nazvanieLabel
            // 
            this.nazvanieLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nazvanieLabel.AutoSize = true;
            this.nazvanieLabel.Location = new System.Drawing.Point(21, 40);
            this.nazvanieLabel.Name = "nazvanieLabel";
            this.nazvanieLabel.Size = new System.Drawing.Size(98, 15);
            this.nazvanieLabel.TabIndex = 3;
            this.nazvanieLabel.Text = "Название Услуги";
            // 
            // stoimostText
            // 
            this.stoimostText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stoimostText.Location = new System.Drawing.Point(24, 106);
            this.stoimostText.Name = "stoimostText";
            this.stoimostText.Size = new System.Drawing.Size(173, 23);
            this.stoimostText.TabIndex = 2;
            // 
            // stoimostLabel
            // 
            this.stoimostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stoimostLabel.AutoSize = true;
            this.stoimostLabel.Location = new System.Drawing.Point(21, 88);
            this.stoimostLabel.Name = "stoimostLabel";
            this.stoimostLabel.Size = new System.Drawing.Size(105, 15);
            this.stoimostLabel.TabIndex = 3;
            this.stoimostLabel.Text = "Стоимость Услуги";
            // 
            // dlitelnostText
            // 
            this.dlitelnostText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dlitelnostText.Location = new System.Drawing.Point(24, 153);
            this.dlitelnostText.Name = "dlitelnostText";
            this.dlitelnostText.Size = new System.Drawing.Size(173, 23);
            this.dlitelnostText.TabIndex = 2;
            // 
            // dlitelnostLabel
            // 
            this.dlitelnostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dlitelnostLabel.AutoSize = true;
            this.dlitelnostLabel.Location = new System.Drawing.Point(21, 135);
            this.dlitelnostLabel.Name = "dlitelnostLabel";
            this.dlitelnostLabel.Size = new System.Drawing.Size(122, 15);
            this.dlitelnostLabel.TabIndex = 3;
            this.dlitelnostLabel.Text = "Длительность Услуги";
            // 
            // opisanieText
            // 
            this.opisanieText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opisanieText.Location = new System.Drawing.Point(24, 308);
            this.opisanieText.Multiline = true;
            this.opisanieText.Name = "opisanieText";
            this.opisanieText.Size = new System.Drawing.Size(317, 76);
            this.opisanieText.TabIndex = 2;
            // 
            // opisanieLabel
            // 
            this.opisanieLabel.AutoSize = true;
            this.opisanieLabel.Location = new System.Drawing.Point(24, 290);
            this.opisanieLabel.Name = "opisanieLabel";
            this.opisanieLabel.Size = new System.Drawing.Size(107, 15);
            this.opisanieLabel.TabIndex = 3;
            this.opisanieLabel.Text = "Описание Усьулги";
            // 
            // skidkaText
            // 
            this.skidkaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skidkaText.Location = new System.Drawing.Point(27, 201);
            this.skidkaText.Name = "skidkaText";
            this.skidkaText.Size = new System.Drawing.Size(116, 23);
            this.skidkaText.TabIndex = 2;
            // 
            // skidkaLabel
            // 
            this.skidkaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skidkaLabel.AutoSize = true;
            this.skidkaLabel.Location = new System.Drawing.Point(24, 183);
            this.skidkaLabel.Name = "skidkaLabel";
            this.skidkaLabel.Size = new System.Drawing.Size(44, 15);
            this.skidkaLabel.TabIndex = 3;
            this.skidkaLabel.Text = "Скидка";
            // 
            // kartinkaUslugi
            // 
            this.kartinkaUslugi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kartinkaUslugi.Image = ((System.Drawing.Image)(resources.GetObject("kartinkaUslugi.Image")));
            this.kartinkaUslugi.Location = new System.Drawing.Point(225, 106);
            this.kartinkaUslugi.Name = "kartinkaUslugi";
            this.kartinkaUslugi.Size = new System.Drawing.Size(116, 118);
            this.kartinkaUslugi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kartinkaUslugi.TabIndex = 4;
            this.kartinkaUslugi.TabStop = false;
            // 
            // kartinkaText
            // 
            this.kartinkaText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kartinkaText.AutoSize = true;
            this.kartinkaText.Location = new System.Drawing.Point(248, 240);
            this.kartinkaText.Name = "kartinkaText";
            this.kartinkaText.Size = new System.Drawing.Size(78, 15);
            this.kartinkaText.TabIndex = 3;
            this.kartinkaText.Text = "Изображение";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kartinkaUslugi);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.kartinkaText);
            this.groupBox1.Controls.Add(this.dlitelnostLabel);
            this.groupBox1.Controls.Add(this.skidkaLabel);
            this.groupBox1.Controls.Add(this.stoimostLabel);
            this.groupBox1.Controls.Add(this.nazvanieLabel);
            this.groupBox1.Controls.Add(this.skidkaText);
            this.groupBox1.Controls.Add(this.dlitelnostText);
            this.groupBox1.Controls.Add(this.opisanieText);
            this.groupBox1.Controls.Add(this.opisanieLabel);
            this.groupBox1.Controls.Add(this.stoimostText);
            this.groupBox1.Location = new System.Drawing.Point(576, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 439);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Изменить услугу:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataSource = this.serviceBindingSource1;
            this.comboBox2.DisplayMember = "Title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(576, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(365, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.schoolDataSet5;
            // 
            // schoolDataSet5
            // 
            this.schoolDataSet5.DataSetName = "SchoolDataSet5";
            this.schoolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSet4
            // 
            this.schoolDataSet4.DataSetName = "SchoolDataSet4";
            this.schoolDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.schoolDataSet4;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 650);
            this.Name = "Edit";
            this.Text = "Управление услугами";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartinkaUslugi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nazvanieLabel;
        private System.Windows.Forms.TextBox stoimostText;
        private System.Windows.Forms.Label stoimostLabel;
        private System.Windows.Forms.TextBox dlitelnostText;
        private System.Windows.Forms.Label dlitelnostLabel;
        private System.Windows.Forms.TextBox opisanieText;
        private System.Windows.Forms.Label opisanieLabel;
        private System.Windows.Forms.TextBox skidkaText;
        private System.Windows.Forms.Label skidkaLabel;
        private System.Windows.Forms.PictureBox kartinkaUslugi;
        private System.Windows.Forms.Label kartinkaText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private SchoolDataSet4 schoolDataSet4;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private SchoolDataSet4TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private SchoolDataSet5 schoolDataSet5;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private SchoolDataSet5TableAdapters.ServiceTableAdapter serviceTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}