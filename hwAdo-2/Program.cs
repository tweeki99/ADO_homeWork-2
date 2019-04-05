using hwAdo2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwAdo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            dataService.CreateGruppaTable();
        }
    }
}
