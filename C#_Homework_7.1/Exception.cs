using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C__Homework_7._1
{
    class BackpackException : ApplicationException
    {
        public BackpackException(string msg) : base(msg) { }
    }
    class WeightException : BackpackException
    {
        public WeightException(string msg) : base(msg) { }
    }

    class VolumeException : BackpackException
    {
        public VolumeException(string msg) : base(msg) { }
    }
}
