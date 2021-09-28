using System.Collections.Generic;

namespace Builder
{
    public class Person
    {
        public Person(string firstName, string lastName, int height, int weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Person: {FirstName}, {LastName}, {Height}, {Weight}";
        }
    }
}