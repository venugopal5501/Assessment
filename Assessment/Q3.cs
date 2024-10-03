using System;

namespace Assessment1
{
    class Student
    {
        private int stud_regno;
        private string stud_name;
        private string degree;
        private string department;
        private int sub_mark1;
        private int sub_mark2;
        private int sub_mark3;

        public int Stud_regno { get => stud_regno; set => stud_regno = value; }
        public string Stud_name { get => stud_name; set => stud_name = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Department { get => department; set => department = value; }
        public int Sub_mark1 { get => sub_mark1; set => sub_mark1 = value; }
        public int Sub_mark2 { get => sub_mark2; set => sub_mark2 = value; }
        public int Sub_mark3 { get => sub_mark3; set => sub_mark3 = value; }

        public virtual double Calculate_total_avg()
        {
            return 0; // Default implementation can be overridden in derived classes
        }
    }

    class UgDegree : Student
    {
        public override double Calculate_total_avg()
        {
            int total = Sub_mark1 + Sub_mark2 + Sub_mark3;
            double avg = total / 3.0;
            Console.WriteLine($"Total Marks of Student: {total}");
            Console.WriteLine($"Average Marks of Student: {avg:F2}");
            return avg;
        }
    }

    class PgDegree : Student
    {
        public override double Calculate_total_avg()
        {
            int total = Sub_mark1 + Sub_mark2 + Sub_mark3;
            double avg = total / 3.0;
            Console.WriteLine($"Total Marks of Student: {total}");
            Console.WriteLine($"Average Marks of Student: {avg:F2}");
            return avg;
        }
    }

    class Q6
    {
        public void Demos()
        {
            while (true) // Loop to keep showing UG/PG options until the user decides to exit
            {
                Console.WriteLine("\n1. UG Degree \n2. PG Degree \n0. Exit");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        UgDegree ug = new UgDegree();
                        GetStudentDetails(ug);
                        ug.Calculate_total_avg();
                        break;

                    case 2:
                        PgDegree pg = new PgDegree();
                        GetStudentDetails(pg);
                        pg.Calculate_total_avg();
                        break;

                    case 0:
                        return; // Exit from Demos method

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }

        private void GetStudentDetails(Student student)
        {
            Console.WriteLine("Enter Student Registration Number:");
            student.Stud_regno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            student.Stud_name = Console.ReadLine();

            Console.WriteLine("Enter Degree:");
            student.Degree = Console.ReadLine();

            Console.WriteLine("Enter Department:");
            student.Department = Console.ReadLine();

            // For UG Degree, marks are out of 100
            // For PG Degree, marks are out of 200
            Console.WriteLine("Enter Subject 1 Marks:");
            student.Sub_mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject 2 Marks:");
            student.Sub_mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject 3 Marks:");
            student.Sub_mark3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}