using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia_Margui
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoJob();
        }
        static void DoJob()
        {
            var elTrabajador = new Trabajador();
            elTrabajador.Trabajo01();
        }

    }
}
