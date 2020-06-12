using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2TaskEF
{
    public partial class Form1 : Form
    {
        ITIEntities db = new ITIEntities();

        public void Genrate()
            {
            var ListInstuctor = (from item in db.Instructors
                                 select item).ToList();

            dataGridViewInstructor.DataSource = ListInstuctor;
            dataGridViewInstructor.Columns.RemoveAt(5);
            dataGridViewInstructor.Columns["Department"].Visible = false;
            Instructor_ID.Text = "";
            Instructor_Name.Text = "";
            Instructor_Degree.Text = "";
            Instructor_Salary.Text = "";
            Department_ID.Text = "";
        }
        public void updateInstructor ()
        {
            var InstructorName = db.Instructors.ToList();
            CompInstructor.DataSource = InstructorName;
            CompInstructor.DisplayMember = "Ins_Name";
        }
        public Form1()
        {
            InitializeComponent();
            updateInstructor();

            Genrate();
          //  dataGridViewInstructor.Columns["Departments"].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Department_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var DepartmentId = db.Departments.Select(x => x.Dept_Id).ToList();
            Department_ID.DataSource = DepartmentId;
            dataGridViewInstructor.Columns["Departments"].Visible = false;





        }

        private void CompInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objInstructor = (Instructor)CompInstructor.SelectedItem;
            if(objInstructor!=null)
            {
                Instructor_ID.Text = objInstructor.Ins_Id.ToString();
                Instructor_Name.Text = objInstructor.Ins_Name;
                Instructor_Degree.Text = objInstructor.Ins_Degree;
                Instructor_Salary.Text = objInstructor.Salary.ToString();
                Department_ID.Text = objInstructor.Dept_Id.ToString();
            }
            else
            {
                MessageBox.Show("object is null");
            }
   


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal SalaryAdded = 0;
                int Id = Convert.ToInt32(Instructor_ID.Text);
                if (Instructor_Salary.Text.Length > 0)
                {
                     SalaryAdded = Convert.ToDecimal(Instructor_Salary.Text);
                }
                else {  }
                int IdDeprt = Convert.ToInt32(Department_ID.Text);

                var AddInstructor = new Instructor { Ins_Id = Id, Ins_Name = Instructor_Name.Text, 
                Ins_Degree=Instructor_Degree.Text,Salary= SalaryAdded,Dept_Id=IdDeprt
                };
                db.Instructors.Add(AddInstructor);
                db.SaveChanges();
                MessageBox.Show(" Added Success");

                updateInstructor();
                Genrate();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Must to enter valid  Data");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(Instructor_ID.Text);
                var IstructorDeleted = db.Instructors.FirstOrDefault(x => x.Ins_Id == Id);
                db.Instructors.Remove(IstructorDeleted);
                db.SaveChanges();
                MessageBox.Show("Deleted ok");
                updateInstructor();

                Genrate();
            }

            catch(Exception Ex)
            {
                MessageBox.Show("No ID");
            }
           


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(Instructor_ID.Text);
              
                var IstructorDeleted = db.Instructors.FirstOrDefault(x => x.Ins_Id == Id);



                IstructorDeleted.Ins_Id = Convert.ToInt32(Instructor_ID.Text);
                IstructorDeleted.Ins_Name = Instructor_Name.Text;
                IstructorDeleted.Ins_Degree = Instructor_Degree.Text;
                if (Instructor_Salary.Text.Length > 0)
                {
                    IstructorDeleted.Salary = Convert.ToDecimal(Instructor_Salary.Text);
                }
                else { IstructorDeleted.Salary = null; }
                IstructorDeleted.Dept_Id = Convert.ToInt32(Department_ID.Text);

                db.SaveChanges();
                MessageBox.Show(" Updated Success");
                updateInstructor();

                Genrate();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Must to enter valid  ");
            }

        }
    }
}
