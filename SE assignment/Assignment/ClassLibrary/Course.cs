using System;

namespace ClassLibrary
{
    public abstract class Course
    {
        string cName;
        string[] topic = new string[10];

        public Course() { }
      
        public Course(string cName)
        {
            this.cName = cName;
        }

        public string CName { get => cName; set => cName = value; }

        public virtual void AddTopic(params string[] a)
        {

        }

        public virtual void Print()
        {
            Console.WriteLine("   Course:"+cName);
            
        }
    }

}
