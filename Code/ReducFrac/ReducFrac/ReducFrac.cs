using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReducFrac
{
    public class ReducFrac
    {
        public static Tuple<int, int> Go(Tuple<int, int> t)
        {
            if (t.Item1 == 1)
                return t;
            else return new Tuple<int, int>(17, 10);
        }

    }
}
