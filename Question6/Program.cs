using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Student : IComparable<Student>
    {
        public String nameOfStudent { get; private set; }
        public String dateOfBirth { get; private set; }
        public int semesterNumber { get; private set; }
        public double cgpa { get; private set; }        

        public Student(String name,String dob,int semester, double gpa)
        {
            this.nameOfStudent = name;
            this.dateOfBirth = dob;
            this.semesterNumber = semester;
            this.cgpa = gpa;

          //  Console.WriteLine(nameOfStudent + " " + dateOfBirth + " " + semesterNumber + " " + cgpa);
        }
        public int CompareTo(Student tempStudent)
        {
         
            if(this.cgpa == tempStudent.cgpa)
            {
                return this.cgpa.CompareTo(tempStudent.cgpa);
            }
            return tempStudent.cgpa.CompareTo(this.cgpa);
        
        }

       



    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
               
                double cgpa = random.NextDouble() * (400-200) + 200;
                cgpa = cgpa / 100;
                cgpa = Math.Round(cgpa, 2);
                //Console.WriteLine(cgpa);

                String studentname = "Student#" + i;
                int semester = random.Next(1,8);
                Student myStudent = new Student(studentname,"23/11/1997",semester,cgpa);
                studentList.Add(myStudent);
            }

            studentList.Sort();

            Console.WriteLine("Student Name         DOB         Semester            CGPA");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (Student s in studentList)
            {
                
            Console.WriteLine(s.nameOfStudent+"         "+s.dateOfBirth+"           "+s.semesterNumber+"            "+s.cgpa+"          ");

            }

            Console.ReadKey();
        }

    }
}
