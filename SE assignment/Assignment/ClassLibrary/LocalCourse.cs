using System;


namespace ClassLibrary
{
    public class LocalCourse : Course
    {
        //string cName;
        string labNumber;
        string[] topic = new string[10];
        public LocalCourse()
        { }
        public LocalCourse(string name, string lab) : base(name)
        {
            labNumber = lab;
        }

        public override void  AddTopic( params string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (topic[i] == null)
                topic[i] = a[i];
            }
        }

        public override void Print()
        {
            Console.WriteLine("\nCampusCourse-------------->");
            Console.WriteLine("     Course:" + base.CName);
            Console.WriteLine("     LabNumber:" + labNumber);
            Console.Write("     Topic:");
            Console.Write("\n       ");
            for (int i = 0; i < topic.Length; i++)
            {
                if (topic[i] != null)
                {
                    Console.Write(topic[i]+",");
                }
            }
        }
    }
}
