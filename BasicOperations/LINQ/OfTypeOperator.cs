using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class OfTypeOperator
    {
        private static readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void OfType()
        {
            var dataSource = new List<Object> { "Chetan", "Rahul", "Krishna", 1, 2, 3, 4, 5 };
            var NewQuery = (from name in dataSource
                         where name is string
                         select name).ToList();

            //foreach(object names in NewQuery)
            //{
            //    log.Info(names);
            //}

            log.Info(NewQuery); 
            Console.ReadKey();
        }
    }
}
