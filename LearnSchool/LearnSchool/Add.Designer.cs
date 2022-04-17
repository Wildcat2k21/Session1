
namespace LearnSchool
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new LearnSchool.SchoolDataSet1();
            this.schoolDataSet = new LearnSchool.SchoolDataSet();
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new LearnSchool.SchoolDataSetTableAdapters.ServiceTableAdapter();
            this.clientTableAdapter = new LearnSchool.SchoolDataSet1TableAdapters.ClientTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet2 = new LearnSchool.SchoolDataSet2();
            this.serviceTableAdapter1 = new LearnSchool.SchoolDataSet2TableAdapters.ServiceTableAdapter();
            this.addStudent = new System.Windows.Forms.Button();
            this.lessonBeginText = new System.Windows.Forms.Label();
            this.lessonContText = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lessonEndCalc = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minutesText2 = new System.Windows.Forms.Label();
            this.hoursText2 = new System.Windows.Forms.Label();
            this.secondsText1 = new System.Windows.Forms.Label();
            this.minutesText1 = new System.Windows.Forms.Label();
            this.hoursText1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).BeginInit();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 522);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataSetBindingSource
            // 
            this.schoolDataSetBindingSource.DataSource = this.schoolDataSet;
            this.schoolDataSetBindingSource.Position = 0;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.schoolDataSetBindingSource;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(597, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 265);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.schoolDataSet2;
            // 
            // schoolDataSet2
            // 
            this.schoolDataSet2.DataSetName = "SchoolDataSet2";
            this.schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // addStudent
            // 
            this.addStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Location = new System.Drawing.Point(503, 138);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(74, 23);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "Сохранить";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // lessonBeginText
            // 
            this.lessonBeginText.AutoSize = true;
            this.lessonBeginText.Location = new System.Drawing.Point(36, 71);
            this.lessonBeginText.Name = "lessonBeginText";
            this.lessonBeginText.Size = new System.Drawing.Size(91, 15);
            this.lessonBeginText.TabIndex = 6;
            this.lessonBeginText.Text = "Начало занятия";
            // 
            // lessonContText
            // 
            this.lessonContText.AutoSize = true;
            this.lessonContText.Location = new System.Drawing.Point(36, 103);
            this.lessonContText.Name = "lessonContText";
            this.lessonContText.Size = new System.Drawing.Size(156, 15);
            this.lessonContText.TabIndex = 6;
            this.lessonContText.Text = "Продолжительноть занятия";
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Controls.Add(this.dateTimePicker1);
            this.infoBox.Controls.Add(this.lessonEndCalc);
            this.infoBox.Controls.Add(this.textBox5);
            this.infoBox.Controls.Add(this.textBox3);
            this.infoBox.Controls.Add(this.addStudent);
            this.infoBox.Controls.Add(this.textBox4);
            this.infoBox.Controls.Add(this.textBox2);
            this.infoBox.Controls.Add(this.textBox1);
            this.infoBox.Controls.Add(this.minutesText2);
            this.infoBox.Controls.Add(this.hoursText2);
            this.infoBox.Controls.Add(this.secondsText1);
            this.infoBox.Controls.Add(this.minutesText1);
            this.infoBox.Controls.Add(this.hoursText1);
            this.infoBox.Controls.Add(this.label3);
            this.infoBox.Controls.Add(this.lessonBeginText);
            this.infoBox.Controls.Add(this.lessonContText);
            this.infoBox.Location = new System.Drawing.Point(597, 393);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(592, 177);
            this.infoBox.TabIndex = 7;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Информация";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lessonEndCalc
            // 
            this.lessonEndCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.lessonEndCalc.Enabled = false;
            this.lessonEndCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessonEndCalc.Location = new System.Drawing.Point(39, 128);
            this.lessonEndCalc.Name = "lessonEndCalc";
            this.lessonEndCalc.Size = new System.Drawing.Size(153, 23);
            this.lessonEndCalc.TabIndex = 8;
            this.lessonEndCalc.Text = "Окончание занятия";
            this.lessonEndCalc.UseVisualStyleBackColor = false;
            this.lessonEndCalc.Click += new System.EventHandler(this.lessonEndCalc_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox5.Location = new System.Drawing.Point(354, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(77, 23);
            this.textBox5.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Location = new System.Drawing.Point(205, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(84, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox4.Location = new System.Drawing.Point(354, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox4.Leave += new System.EventHandler(this.timeBoxes_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Location = new System.Drawing.Point(205, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(205, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.timeBoxes_Leave);
            // 
            // minutesText2
            // 
            this.minutesText2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minutesText2.AutoSize = true;
            this.minutesText2.Location = new System.Drawing.Point(437, 136);
            this.minutesText2.Name = "minutesText2";
            this.minutesText2.Size = new System.Drawing.Size(39, 15);
            this.minutesText2.TabIndex = 6;
            this.minutesText2.Text = "минут";
            // 
            // hoursText2
            // 
            this.hoursText2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hoursText2.AutoSize = true;
            this.hoursText2.Location = new System.Drawing.Point(295, 136);
            this.hoursText2.Name = "hoursText2";
            this.hoursText2.Size = new System.Drawing.Size(38, 15);
            this.hoursText2.TabIndex = 6;
            this.hoursText2.Text = "часов";
            // 
            // secondsText1
            // 
            this.secondsText1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.secondsText1.AutoSize = true;
            this.secondsText1.Location = new System.Drawing.Point(295, 103);
            this.secondsText1.Name = "secondsText1";
            this.secondsText1.Size = new System.Drawing.Size(43, 15);
            this.secondsText1.TabIndex = 6;
            this.secondsText1.Text = "секунд";
            // 
            // minutesText1
            // 
            this.minutesText1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minutesText1.AutoSize = true;
            this.minutesText1.Location = new System.Drawing.Point(437, 71);
            this.minutesText1.Name = "minutesText1";
            this.minutesText1.Size = new System.Drawing.Size(39, 15);
            this.minutesText1.TabIndex = 6;
            this.minutesText1.Text = "минут";
            // 
            // hoursText1
            // 
            this.hoursText1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hoursText1.AutoSize = true;
            this.hoursText1.Location = new System.Drawing.Point(295, 71);
            this.hoursText1.Name = "hoursText1";
            this.hoursText1.Size = new System.Drawing.Size(38, 15);
            this.hoursText1.TabIndex = 6;
            this.hoursText1.Text = "часов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начало занятия";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataSource = this.serviceBindingSource1;
            this.comboBox2.DisplayMember = "Title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(784, 341);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(405, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Клиент";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(784, 370);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(405, 23);
            this.textBox6.TabIndex = 10;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 601);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1235, 640);
            this.Name = "Add";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private SchoolDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SchoolDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet2 schoolDataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private SchoolDataSet2TableAdapters.ServiceTableAdapter serviceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label lessonBeginText;
        private System.Windows.Forms.Label lessonContText;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Button lessonEndCalc;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label minutesText2;
        private System.Windows.Forms.Label hoursText2;
        private System.Windows.Forms.Label secondsText1;
        private System.Windows.Forms.Label minutesText1;
        private System.Windows.Forms.Label hoursText1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
    }
}