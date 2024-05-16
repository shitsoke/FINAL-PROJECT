﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database1
{
    public partial class StudentEnrollmentEntry : Form
    {
        public StudentEnrollmentEntry()
        {
            InitializeComponent();
        }
        public static class DatabaseConnectionString
        {
            public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\C#\\Database1\\Database11.accdb";
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            Hide();
            main.ShowDialog();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GiveDataToSubjectEnrollmentGridView()
        {
            string query = "SELECT schedule.*, subject.SFSUBJUNITS FROM SUBJECTSCHEDFILE schedule LEFT JOIN SUBJECTFILE subject ON schedule.SSFSUBJCODE = subject.SFSUBJCODE";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    EnrollmentGridView.Rows.Add(
                        row["SSFEDPCODE"],
                        row["SSFSUBJCODE"],
                        row["SSFSTARTTIME"],
                        row["SSFENDTIME"],
                        row["SSFDAYS"],
                        row["SSFROOM"],
                        row["SFSUBJUNITS"]
                    );
                }
            }
        }


        private bool ValidateInputs()
        {
           
            string[] requiredFields = {
        IdNumberTextBox.Text,
        NameTextBox.Text,
        CourseTextBox.Text,
        EdpCodeTextBox.Text,
        YearTextBox.Text,
        EncodedTextBox.Text,
        DateTimePicker.Text,
        TotalUnitTextBox.Text
    };

            
            if (requiredFields.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Enter Required Fields");
                return false;
            }

            
            if (EnrollmentGridView.Rows.Count <= 1)
            {
                MessageBox.Show("Datagrid is empty. Please fill.");
                return false;
            }

            return true;
        }

        private bool IsStudentAlreadyEnrolled()
        {
            string query = "SELECT * FROM ENROLLMENTHEADERFILE WHERE ENRHFSTUDID = @StudentID";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@StudentID", IdNumberTextBox.Text);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable.Rows.Count > 0;
            }
        }

        private void SaveEnrollmentDetails()
        {
            string query = "SELECT * FROM ENROLLMENTDETAILFILE WHERE 1=0";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            {
                connection.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                using (OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataGridViewRow gridRow in EnrollmentGridView.Rows)
                    {
                        if (!gridRow.IsNewRow)
                        {
                            string edpCode = gridRow.Cells["EDPCode"].Value.ToString();
                            if (!IsValidEnroll(edpCode))
                            {
                                MessageBox.Show("Student has already enrolled in the class");
                                return;
                            }

                            
                            var existingRow = dataTable.AsEnumerable().FirstOrDefault(row =>
                                row.Field<long>("ENRDFSTUDID") == Convert.ToInt64(IdNumberTextBox.Text) &&
                                row.Field<string>("ENRDFSTUDSUBJCODE") == gridRow.Cells["SubjectCode"].Value.ToString() &&
                                row.Field<string>("ENRDFSTUDEDPCODE") == edpCode);

                            if (existingRow == null)
                            {
                                DataRow dataRow = dataTable.NewRow();
                                dataRow["ENRDFSTUDID"] = Convert.ToInt64(IdNumberTextBox.Text);
                                dataRow["ENRDFSTUDSUBJCODE"] = gridRow.Cells["SubjectCode"].Value.ToString();
                                dataRow["ENRDFSTUDEDPCODE"] = edpCode;
                                dataRow["ENRDFSTUDSTATUS"] = "AC";
                                dataTable.Rows.Add(dataRow);

                                UpdateClassSize(edpCode);
                            }
                            else
                            {
                                MessageBox.Show("Duplicate enrollment detail detected.");
                            }
                        }
                    }

                    
                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.UpdateCommand = builder.GetUpdateCommand();

                    
                    foreach (OleDbParameter parameter in adapter.InsertCommand.Parameters)
                    {
                        if (parameter.OleDbType == OleDbType.VarChar)
                            parameter.Size = 255;
                    }
                    foreach (OleDbParameter parameter in adapter.UpdateCommand.Parameters)
                    {
                        if (parameter.OleDbType == OleDbType.VarChar)
                            parameter.Size = 255; 
                    }

                    adapter.Update(dataTable);
                }
            }
        }

        private void SaveEnrollmentHeader()
        {
            string query = "SELECT * FROM ENROLLMENTHEADERFILE WHERE 1=0";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            {
                connection.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                using (OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    var existingRow = dataTable.AsEnumerable().FirstOrDefault(row =>
                        row.Field<long>("ENRHFSTUDID") == Convert.ToInt64(IdNumberTextBox.Text));

                    if (existingRow == null)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["ENRHFSTUDID"] = Convert.ToInt64(IdNumberTextBox.Text);
                        dataRow["ENRHFSTUDDATEENROLL"] = DateTimePicker.Text;
                        dataRow["ENRHFSTUDSCHLYR"] = YearTextBox.Text;
                        dataRow["ENRHFSTUDENCODER"] = EncodedTextBox.Text;
                        dataRow["ENRHFSTUDTOTALUNITS"] = Convert.ToDouble(TotalUnitTextBox.Text);
                        dataRow["ENRHFSTUDSTATUS"] = "EN";
                        dataTable.Rows.Add(dataRow);

                        adapter.InsertCommand = builder.GetInsertCommand();
                        foreach (OleDbParameter parameter in adapter.InsertCommand.Parameters)
                        {
                            if (parameter.OleDbType == OleDbType.VarChar)
                                parameter.Size = 255; 
                        }

                        adapter.Update(dataTable);
                    }
                    else
                    {
                        MessageBox.Show("Student enrollment header already exists.");
                    }
                }
            }
        }

            private bool IsValidEnroll(string edpCode)
            {
                string query = "SELECT * FROM ENROLLMENTDETAILFILE WHERE ENRDFSTUDID = @StudentID AND ENRDFSTUDEDPCODE = @EDPCode";
                using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StudentID", IdNumberTextBox.Text);
                    adapter.SelectCommand.Parameters.AddWithValue("@EDPCode", edpCode);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable.Rows.Count == 0;
                }
            }

        private void UpdateClassSize(string edpCode)
        {
            string query = "SELECT * FROM SUBJECTSCHEDFILE WHERE SSFEDPCODE = @EDPCode";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            {
                connection.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                using (OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter))
                {
                    adapter.SelectCommand.Parameters.Add("@EDPCode", OleDbType.VarChar, 255).Value = edpCode.Trim();

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow dataRow = dataTable.Rows[0];

                        int classSize = DBNull.Value.Equals(dataRow["SSFCLASSSIZE"]) ? 0 : Convert.ToInt32(dataRow["SSFCLASSSIZE"]);
                        classSize++;
                        dataRow["SSFCLASSSIZE"] = classSize;

                        if (classSize >= Convert.ToInt32(dataRow["SSFMAXSIZE"]))
                        {
                            dataRow["SSFSTATUS"] = "Cl";
                        }

                        adapter.UpdateCommand = builder.GetUpdateCommand();

                        foreach (OleDbParameter parameter in adapter.UpdateCommand.Parameters)
                        {
                            if (parameter.OleDbType == OleDbType.VarChar)
                                parameter.Size = 255; 
                        }

                        adapter.Update(dataTable);
                    }
                }
            }
        }

        private void LoadStudentDetails()
        {
            string query = "SELECT * FROM STUDENTFILE WHERE ID = @ID";
            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@ID", IdNumberTextBox.Text.Trim());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];

                    NameTextBox.Clear();
                    CourseTextBox.Clear();
                    YearTextBox.Clear();

                    NameTextBox.Text = $"{dataRow["STFSTUDFNAME"]} {dataRow["STFSTUDMNAME"]} {dataRow["STFSTUDLNAME"]}";
                    CourseTextBox.Text = dataRow["STFSTUDCOURSE"].ToString();
                    YearTextBox.Text = dataRow["STFSTUDYEAR"].ToString();
                }
                else
                {
                    MessageBox.Show("ID not found");
                }
            }
        }

        private void AddSubjectToGrid()
        {
            string query = "SELECT schedule.*, subject.SFSUBJUNITS FROM SUBJECTSCHEDFILE schedule LEFT JOIN SUBJECTFILE subject ON schedule.SSFSUBJCODE = subject.SFSUBJCODE WHERE schedule.SSFEDPCODE = @EDPCode";

            using (OleDbConnection connection = new OleDbConnection(DatabaseConnectionString.connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@EDPCode", EdpCodeTextBox.Text.Trim());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("EDP code not found");
                    return;
                }

                DataRow dataRow = dataTable.Rows[0];

                if (CheckDupesGrid(EdpCodeTextBox.Text))
                {
                    MessageBox.Show("Duplicate subject EDP code is not allowed");
                    return;
                }

                if (!IsActiveSubject(dataRow))
                {
                    MessageBox.Show("Subject is found but not active");
                    return;
                }

                EnrollmentGridView.Rows.Add(
                    dataRow["SSFEDPCODE"],
                    dataRow["SSFSUBJCODE"],
                    dataRow["SSFSTARTTIME"],
                    dataRow["SSFENDTIME"],
                    dataRow["SSFDAYS"],
                    dataRow["SSFROOM"],
                    dataRow["SFSUBJUNITS"]
                );

                if (double.TryParse(TotalUnitTextBox.Text, out double totalUnits))
                {
                    totalUnits += Convert.ToDouble(dataRow["SFSUBJUNITS"]);
                    TotalUnitTextBox.Text = totalUnits.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid total units format");
                }
            }
        }

        private bool CheckDupesGrid(string edpCode)
        {
            foreach (DataGridViewRow row in EnrollmentGridView.Rows)
            {
                if (row.Cells["EDPCode"].Value?.ToString() == edpCode)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsActiveSubject(DataRow row)
        {
            string status = row["SSFSTATUS"].ToString().ToUpper();
            return status == "AC";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EnrollmentGridView.Rows.Clear();
        }

        private void EdpCodeTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddSubjectToGrid();
            }
        }

        private void IdNumberTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadStudentDetails();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(CourseTextBox.Text) ||
                string.IsNullOrWhiteSpace(EdpCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(YearTextBox.Text) ||
                string.IsNullOrWhiteSpace(EncodedTextBox.Text) ||
                string.IsNullOrWhiteSpace(DateTimePicker.Text) ||
                string.IsNullOrWhiteSpace(TotalUnitTextBox.Text))
            {
                MessageBox.Show("Enter Required Fields");
                return;
            }

            if (!double.TryParse(TotalUnitTextBox.Text, out double totalUnits))
            {
                return;
            }

            if (IsStudentAlreadyEnrolled())
            {
                MessageBox.Show("Student is Already Enrolled");
                return;
            }

            SaveEnrollmentDetails();
            SaveEnrollmentHeader();

            MessageBox.Show("Subjects Enrolled");
        }
    }
}

