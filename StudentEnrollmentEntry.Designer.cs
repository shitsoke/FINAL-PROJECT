namespace Database1
{
    partial class StudentEnrollmentEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.EnrollmentGridView = new System.Windows.Forms.DataGridView();
            this.EDPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARTTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EncodedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnitTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Enrollment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number:";
            // 
            // IdNumberTextBox
            // 
            this.IdNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IdNumberTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberTextBox.Location = new System.Drawing.Point(149, 74);
            this.IdNumberTextBox.Name = "IdNumberTextBox";
            this.IdNumberTextBox.Size = new System.Drawing.Size(100, 25);
            this.IdNumberTextBox.TabIndex = 2;
            this.IdNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumberTextBox_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(12, 148);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(67, 19);
            this.Course.TabIndex = 5;
            this.Course.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "EDP Code:";
            // 
            // EdpCodeTextBox
            // 
            this.EdpCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EdpCodeTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdpCodeTextBox.Location = new System.Drawing.Point(149, 203);
            this.EdpCodeTextBox.Name = "EdpCodeTextBox";
            this.EdpCodeTextBox.Size = new System.Drawing.Size(100, 25);
            this.EdpCodeTextBox.TabIndex = 10;
            this.EdpCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdpCodeTextBox_KeyPress_1);
            // 
            // EnrollmentGridView
            // 
            this.EnrollmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCODE,
            this.SUBJECTCODE,
            this.STARTTIME,
            this.ENDTIME,
            this.DAYS,
            this.ROOM,
            this.UNITS});
            this.EnrollmentGridView.Location = new System.Drawing.Point(21, 254);
            this.EnrollmentGridView.Name = "EnrollmentGridView";
            this.EnrollmentGridView.Size = new System.Drawing.Size(743, 150);
            this.EnrollmentGridView.TabIndex = 11;
            this.EnrollmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EDPCODE
            // 
            this.EDPCODE.HeaderText = "EDP Code";
            this.EDPCODE.Name = "EDPCODE";
            // 
            // SUBJECTCODE
            // 
            this.SUBJECTCODE.HeaderText = "Subject Code";
            this.SUBJECTCODE.Name = "SUBJECTCODE";
            // 
            // STARTTIME
            // 
            this.STARTTIME.HeaderText = "Start Time";
            this.STARTTIME.Name = "STARTTIME";
            // 
            // ENDTIME
            // 
            this.ENDTIME.HeaderText = "End Time";
            this.ENDTIME.Name = "ENDTIME";
            // 
            // DAYS
            // 
            this.DAYS.HeaderText = "Days";
            this.DAYS.Name = "DAYS";
            // 
            // ROOM
            // 
            this.ROOM.HeaderText = "Room";
            this.ROOM.Name = "ROOM";
            // 
            // UNITS
            // 
            this.UNITS.HeaderText = "Units";
            this.UNITS.Name = "UNITS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(526, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Units:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(564, 208);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Encoded By:";
            // 
            // EncodedTextBox
            // 
            this.EncodedTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodedTextBox.Location = new System.Drawing.Point(128, 431);
            this.EncodedTextBox.Name = "EncodedTextBox";
            this.EncodedTextBox.Size = new System.Drawing.Size(163, 25);
            this.EncodedTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(352, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(450, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(149, 109);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(173, 25);
            this.NameTextBox.TabIndex = 21;
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTextBox.Location = new System.Drawing.Point(149, 146);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(100, 25);
            this.CourseTextBox.TabIndex = 22;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(364, 155);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 25);
            this.YearTextBox.TabIndex = 23;
            // 
            // TotalUnitTextBox
            // 
            this.TotalUnitTextBox.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUnitTextBox.Location = new System.Drawing.Point(630, 434);
            this.TotalUnitTextBox.Name = "TotalUnitTextBox";
            this.TotalUnitTextBox.Size = new System.Drawing.Size(100, 25);
            this.TotalUnitTextBox.TabIndex = 24;
            // 
            // StudentEnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(787, 559);
            this.Controls.Add(this.TotalUnitTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncodedTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EnrollmentGridView);
            this.Controls.Add(this.EdpCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentEnrollmentEntry";
            this.Text = "StudentEnrollmentEntry";
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EdpCodeTextBox;
        private System.Windows.Forms.DataGridView EnrollmentGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EncodedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARTTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITS;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox TotalUnitTextBox;
    }
}