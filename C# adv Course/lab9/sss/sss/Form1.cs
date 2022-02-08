using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITIDBContext dp=new ITIDBContext();
            dgv_students.DataSource = dp.Students.Select(n => new {n.St_Fname,n.St_Lname,n.St_Id}).ToList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
              
                St_Fname=Fn_txt.Text,
                St_Lname=Ln_txt.Text,
               // Dept_Id=10
                
                


            };

            ITIDBContext dp = new ITIDBContext();
            dp.Students.Add(student);   
            dp.SaveChanges();
        }
    }
}
