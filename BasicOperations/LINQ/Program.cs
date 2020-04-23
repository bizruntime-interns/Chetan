using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            List O = new List(); //calling List class
            O.Odd();

            //calling Employee Class
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Chetan",Skills=new List<string>(){ "C#","Java","C"} },
                new Employee(){Id=2,Name="Rahul",Skills=new List<string>(){"VB","SQL","IT"} }
            };

            List<string> ProgrammingSkills = employees.SelectMany(skill => skill.Skills).ToList();

            foreach (string skillset in ProgrammingSkills)
            {
                log.Info(skillset);
            }

            IEnumerable<Employee> query = (from emp in employees
                                           where emp.Id == 2         //operators
                                           select emp).ToList();


            foreach (var item in query)
            {
                log.Info(item.Name);
            }

            // SelectMany Operation
            SelectManyOperation M = new SelectManyOperation();
            M.SelectMany();

            //OfType Operation
            OfTypeOperator OT = new OfTypeOperator();
            OT.OfType();
            Console.ReadKey();
        }
    }
}
