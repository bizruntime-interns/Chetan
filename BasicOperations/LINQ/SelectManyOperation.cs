using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class SelectManyOperation
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void SelectMany()
        {
            List<string> strlist = new List<string> { "Chetan", "Krishna" };
            List<char> result = strlist.SelectMany(x => x).ToList();

            List<char> queryResult = (from rec in strlist
                               from ch in rec
                               select ch).ToList();


            log.Info(queryResult);
         
        }
    }
}
