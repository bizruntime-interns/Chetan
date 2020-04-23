using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class OrderByOperation
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void OrderBy()
        {
            List<string> name = new List<string> { "Chetan","Shayam", "Ram" };
            List<string> query = (from names in name
                                 orderby names // descending
                                 select names).ToList();

            foreach(string queryName in query)
            {
                log.Info(queryName);
            }
        }
    }
}
