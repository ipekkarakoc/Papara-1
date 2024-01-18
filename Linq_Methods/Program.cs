using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person {Name = "ipek", Age = 24, Gender = "female", Job = "engineer", MaritalStatus = "single", Salary = 7500},
                new Person {Name = "lale", Age = 30, Gender = "female", Job = "doctor", MaritalStatus = "married", Salary = 15400},
                new Person {Name = "ali", Age = 45, Gender = "male", Job = "engineer", MaritalStatus = "married", Salary = 15500},
                new Person {Name = "mehmet", Age = 35, Gender = "male", Job = "doctor", MaritalStatus = "married", Salary = 22000},
                new Person {Name = "irem", Age = 26, Gender = "female", Job = "nurse", MaritalStatus = "single", Salary = 7500},
                new Person {Name = "okan", Age = 32, Gender = "male", Job = "pilot", MaritalStatus = "single", Salary = 17500},
                new Person {Name = "volkan", Age = 27, Gender = "male", Job = "engineer", MaritalStatus = "single", Salary = 9500},
                new Person {Name = "zeynep", Age = 48, Gender = "female", Job = "engineer", MaritalStatus = "single", Salary = 16500},
                new Person {Name = "ilkay", Age = 36, Gender = "female", Job = "nurse", MaritalStatus = "married", Salary = 12000},
            };

            #region Where
            //Returns values from the collection based on a predicate function

            var resultWhere = persons.Where(p => p.Age > 30 && p.Salary > 10000);

            
            foreach (var person in resultWhere)
            {
                Console.WriteLine(person.Name); 
            }
            #endregion

            #region OrderBy
            //Sorts the elements in the collection based on specified fields in ascending or decending order

            Console.WriteLine("**************");
            
            var resultOrderby = persons.OrderBy(p => p.Name);

            foreach (var person in resultOrderby)
            {
                Console.WriteLine(person.Name);
            }
            #endregion

            #region Select
            //It is used to format the result of the query as per our requirement

            Console.WriteLine("**************");
            
            var resultSelect = persons.Select(p => p.Salary*30/100);
            
            foreach (var person in resultSelect)
            {
                Console.WriteLine(person);
            }

            #endregion

            #region GroupBy
            //Returns groups of elements based on some key value

            Console.WriteLine("**************");
            
            var resultGroupby = persons.GroupBy(p => p.Job);
            
            foreach (var person in resultGroupby)
            {
                Console.WriteLine($"job: {person.Key}");

                foreach(var p in person)
                {
                    Console.WriteLine($"  - {p.Name}, {p.Age} ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }         
    public class Person
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string MaritalStatus { get; set; }
    }
}










