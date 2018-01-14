using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCounter
{
    class Box<T>
    {
        private int time;

        Box BoxContents = new Box();

        public object BoxContents { get; private set; }
    }
}
