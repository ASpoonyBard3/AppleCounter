using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Zebra>
            {
                new Zebra(), //works fine
                
            };
        }
        private class Zebra
        {
            public Zebra()
            {
            }

            internal void Feed()
            {
                throw new NotImplementedException();
            }
        }
    }
}
