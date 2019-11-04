using System;


namespace ClassLibrary
{
    public class Student:Person
    {
        Teacher[] teachers = new Teacher[4];

        public Student(string name,string id):base(name,id)
        { }

        public string SName
        {
            get { return base.PName; }
        }
        public string SId
        {
            get { return base.Id; }
        }

        public void AddTeacher(Teacher t)
        {
            for(int i=0;i<teachers.Length;i++)
            {
                if (teachers[i] == null)
                {
                    teachers[i] = t;
                    break;
                }

                }
        }


        public Teacher GetTeacher(int i)
        {
            return teachers[i];
        }
    }
}
