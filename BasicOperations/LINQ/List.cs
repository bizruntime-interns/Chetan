using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class List
    {
        private static readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Odd()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var query = from obj in num
                        where obj % 2 != 0
                        select obj;

            foreach (var obj in query)
            {
                log.Info(obj);
            }
        }
    }
}
