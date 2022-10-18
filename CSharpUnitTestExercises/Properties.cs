using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpUnitTestExercises
{
    /// This class will help to give you an overview of getters, setters and type checking
    public class Properties
    {
        /*  Return a list containing just the first names of the people in the given list
         *  The names should be in the same order as the original list
         */
        public IEnumerable<string> FirstNames(List<Person> people)
        {
            return people.Select(person => person.firstName);
        }

        /*  Return a list containing the full names of the people in the given list
         *  The names should be in the same order as the original list
         *  In this case, note the fullName property is read-only because only a getter method is defined
         */
        public IEnumerable<string> FullNames(List<Person> people)
        {
            return people.Select(person => person.GetFullName);
        }

        /*  Modify the "Person.firstName" and "Person.lastName"
         *  values of the given "Person" by making all letters upper case
         *  Note: System.Strings has a built in method to convert a string to upper case
         */
        public void UpperCaseNames(Person person)
        {
            person.firstName = person.firstName.ToUpper();
            person.lastName = person.lastName.ToUpper();
            return;
           

        }

        /*  Create a list of "Person" objects with the given full names.
         *  You will need to split each full name yourself, delimiting with a space.
         */
        public List<Person> CreatePeople(string[] names)
        {
            List<Person> list = new List<Person>();
            foreach (string name in names)
            {
                string[] bothname = name.Split(' ');
                list.Add(new Person { firstName = bothname[0], lastName = bothname[1] });
             }
            return list;
        }

        /* 
         *  Return a list containing the heights of the people in the given list.
         *  The heights should be in the same order as the original list of "Person" objects
         *  Note: In this case, "Person.height" is a field, not a property, due to the lack
         *  of getters and setters
         */
        public IEnumerable<int> Heights(List<Person> people)
        {
            return people.Select(person => person.height);

        }
    }

    public class Person
    {
        public int height;
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string GetFullName
        {
            get { return string.Format("{0} {1}", firstName, lastName); }
        }
    }
}







