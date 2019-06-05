﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
    

namespace WindowsFormsApp1
{
    public partial class EmployeeSignup : Form
    {
        long mobileno, salary;
        string username, address, password, emailid;
        DateTime dateofbirth;
        public EmployeeSignup()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            mobileno = Convert.ToInt64(textBox3.Text);
            emailid = textBox4.Text;
            dateofbirth = dateTimePicker1.Value;
            salary = Convert.ToInt64(textBox5.Text);
            address = textBox6.Text;
            int d=DatabaseConnection.InsertEmployee(username, password, mobileno, emailid, dateofbirth, salary, address);
            if (d == 1)
            {
                MessageBox.Show("employee added successesfuly");
            }
            else
            {
                MessageBox.Show("employee not added");
            }
        }
    }
}