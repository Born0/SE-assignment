using System;


namespace ClassLibrary
{
    public class OffsiteCourse:Course
    {
        //string cName;
        string town;
        string[] topic = new string[10];
        public OffsiteCourse() { }
        public OffsiteCourse(string name, string tw):base(name)
        {
            town = tw;
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
            Console.WriteLine("\nOffsiteCourse-------------->");
            Console.WriteLine("     Course:" + base.CName);
            Console.WriteLine("     Town:" + town);
            Console.Write("     Topic:");
            Console.Write("\n       ");
            for (int i = 0; i < topic.Length; i++)
            {
                if (topic[i] != null)
                {
                    Console.Write(topic[i] + ",");
                }
            }
        }
    }
}
