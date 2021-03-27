using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            emp.Add(new Employee("John", "Doe", 1));
            emp.Add(new Employee("Joe", "Doe", 2));
            emp.Add(new Employee("Jason", "Roy", 3));
            emp.Add(new Employee("Andrew", "Doe", 4));
            emp.Add(new Employee("Hafeez", "Kardar", 5));
            emp.Add(new Employee("Joe", "Doe", 6));
            emp.Add(new Employee("Ricky", "Ponting", 7));
            emp.Add(new Employee("Michel", "Clarke", 8));
            emp.Add(new Employee("Joe", "David", 9));
            emp.Add(new Employee("David", "Hussy", 10));

            List<Employee> joeName = new List<Employee>();
            foreach(var item in emp)
            {
                if(item.FirstName == "Joe")
                {
                    joeName.Add(item);
                }
            }

            List<Employee> joeLambda = emp.FindAll(e => (e.FirstName == "Joe"));

            Console.WriteLine("Numbe of employee whose first name is joe: " + joeLambda.Count);
            
            List<Employee> idGreater = emp.FindAll(e => (e.Id > 5));

            Console.WriteLine("Numbe of employee whose id is greater than 5: " + idGreater.Count);
            
            Console.ReadKey();
        }
    }
}
