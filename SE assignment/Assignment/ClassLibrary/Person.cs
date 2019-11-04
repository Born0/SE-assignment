using System;


namespace ClassLibrary
{
    public class Person
    {
        string pName;
        string id;

        public string Id { get => id; set => id = value; }
        public string PName { get => pName; set => pName = value; }

        public Person() { }
        public Person(string name,string id)
        {
            this.pName = name;
            this.id = id;
        }
    }
}
