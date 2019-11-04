using System;

namespace ClassLibrary
{
    public class Teacher:Person
    { 
        Course[] course = new Course[5];

        public Teacher() { }
        public Teacher(string nm,string id):base(nm,id)
        {
        }

        public string TName
        {
            get { return base.PName; }
        }
        public string TId
        {
            get { return base.Id; }
        }

        public void AddCourse(params Course[] a) 
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (course[i] == null)
                {
                    course[i] = a[i];
                }
            }
        }


        public Course GetCourse(int i)
        {
            return course[i];
        }

        public void Print()
        {
            Console.WriteLine("Teacher:"+base.PName);
            Console.WriteLine("Teacher Id:"+base.Id);
        }



    }
}
