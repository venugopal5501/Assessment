using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Student
    {
        private int stud_regno;
        private string stud_name;
        private string degree;
        private string Department;
        private int sub_mark1;
        private int sub_mark2;
        private int sub_mark3;

        public int Stud_regno
        {
            get { return stud_regno; }
            set { stud_regno = value; }

        }
        public string Stud_name
        {
            get { return stud_name; }
            set { stud_name = value; }

        }
        public string Degree
        {
            get { return degree; }
            set { degree = value; }

        }
        public string department
        {
            get { return Department; }
            set { Department = value; }

        }
        public int Sub_mark1
        {
            get { return sub_mark1; }
            set { sub_mark1 = value; }

        }
        public int Sub_mark2
        {
            get { return sub_mark2; }
            set { sub_mark2 = value; }

        }
        public int Sub_mark3
        {
            get { return sub_mark3; }
            set { sub_mark3 = value; }

        }
        public virtual int Calculate_total_avg()
        {
            return 1;
        }

    }
    class UgDegree : Student
    {
        public override int Calculate_total_avg()
        {

            int total = Sub_mark1 + Sub_mark2 + Sub_mark3;
            int avg = total / 3;
            Console.WriteLine("Total Marks of Student: " + total);
            Console.WriteLine("Average Marks of Student: " + avg);
            return avg;
        }

    }
    class PgDegree : Student
    {
        public override int Calculate_total_avg()
        {
            int total = Sub_mark1 + Sub_mark2 + Sub_mark3;
            int avg = total / 3;
            Console.WriteLine("Total Marks of Student: " + total);
            Console.WriteLine("Average Marks of Student: " + avg);
            return avg;
        }

    }
    class Program
    {
        public static void Main(string []args)
        {
            l:
            Console.WriteLine("1. UG Degree \n2. PG Degree \n 0.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UgDegree ug = new UgDegree();
                    Console.WriteLine("Enter Student Registration Number:");
                    ug.Stud_regno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Student Name:");
                    ug.Stud_name = Console.ReadLine();
                    Console.WriteLine("Enter Degree:");
                    ug.Degree = Console.ReadLine();
                    Console.WriteLine("Enter Department:");
                    Console.WriteLine("Enter the mark out of 100");
                    ug.department = Console.ReadLine();
                    Console.WriteLine("Enter Subject 1 Marks:");
                    ug.Sub_mark1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Subject 2 Marks:");
                    ug.Sub_mark2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Subject 3 Marks:");
                    ug.Sub_mark3 = Convert.ToInt32(Console.ReadLine());
                    ug.Calculate_total_avg();
                    goto l;
                case 2:
                    PgDegree pg = new PgDegree();
                    Console.WriteLine("Enter Student Registration Number:");
                    pg.Stud_regno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Student Name:");
                    pg.Stud_name = Console.ReadLine();
                    Console.WriteLine("Enter Degree:");
                    pg.Degree = Console.ReadLine();
                    Console.WriteLine("Enter Department:");
                    pg.department = Console.ReadLine();
                    Console.WriteLine("Enter the mark out of 200");
                    Console.WriteLine("Enter Subject 1 Marks:");
                    pg.Sub_mark1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Subject 2 Marks:");
                    pg.Sub_mark2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Subject 3 Marks:");
                    pg.Sub_mark3 = Convert.ToInt32(Console.ReadLine());
                    pg.Calculate_total_avg();
                    goto l;
                    case 0:
                    break;
            }


        }
    }
}
