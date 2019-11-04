using ClassLibrary;
using System;

namespace _18_36449_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new LocalCourse("OOP2", "1234");
            c1.AddTopic("Using Classes and Objects", "Defining Classes", "OOP Principles", "Property");

            Course c2 = new LocalCourse("OOAD", "5678");
            c2.AddTopic("Introduction to Modelling", "Introduction to UML", "Use Case Diagram", "Class Diagram");

            Course c3 = new OffsiteCourse("Cyber Security", "Sylhet");
            c3.AddTopic("Security", "Encryption", "Algorithm", "Cyber Ethics");

            Teacher t1 = new Teacher("Victor Stany Rozario", "15-34939-1");
            t1.AddCourse(c1, c2);
            Teacher t2 = new Teacher("SUPTA RICHARD PHILIP", "14-54463-2");
            t2.AddCourse(c3);

            Student s1 = new Student("Borno", "18-36449-1");
            s1.AddTeacher(t2);
            s1.AddTeacher(t1);


            TeacherDetails(t1);
            TeacherDetails(t2);
            StudentDetails(s1);



        }

        public static void TeacherDetails (Teacher t)
        {
            if (t.TName != null)
            {
                Console.WriteLine("Teacher:" + t.TName);
                Console.WriteLine("Teacher Id:" + t.Id);
            }
            for (int i = 0; i < 2; i++)
            {
                if (t.GetCourse(i) != null)
                    t.GetCourse(i).Print();
            }
            Console.WriteLine("\n\n");
        }

        public static void StudentDetails(Student s)
        {

            if (s.SName != null)
            {
                Console.WriteLine("Student:" + s.SName);
                Console.WriteLine("Student Id:" + s.SId);
            }
            for (int i = 0; i < 2; i++)
            {
                if (s.GetTeacher(i) != null)
                    s.GetTeacher(i).Print();
            }
        }



    }
}
