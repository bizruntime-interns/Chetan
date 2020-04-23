using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            List<int> NumSeries1 = new List<int> { 1, 2, 3, 4, 5, 6, 2, 3 };
            List<int> NumSeries2 = new List<int> { 4, 5, 6, 7, 8, 9 };

            List<int> DistinctQuery = NumSeries1.Distinct().ToList();

            List<int> ExceptQuery = NumSeries1.Except(NumSeries2).ToList();

            List<int> IntersectQuery = NumSeries1.Intersect(NumSeries2).ToList();

            List<int> UnionQuery = NumSeries1.Union(NumSeries2).ToList();

            foreach (int num in  UnionQuery)
            {
                log.Info(num);
            }
            Console.ReadKey();
        }
    }
}
