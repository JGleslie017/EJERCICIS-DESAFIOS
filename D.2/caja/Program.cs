using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace Superficie_frontal
    {
        class Caja
        {
            public int Alto { get; set; }
            public int Largo { get; set; }

            public int SuperficieFrontal
            {
                get
                {
                    return Alto * Largo;
                }
            }
        }
    }
}
    }
}
