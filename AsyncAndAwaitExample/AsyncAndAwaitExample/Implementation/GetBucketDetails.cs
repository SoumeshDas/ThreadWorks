using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwaitExample.Implementation
{
    class GetBucketDetails
    {
        public static Tuple<string,int> VideoCallerIntergotaion()
        {
            Thread.Sleep(30);
            Tuple<string, int> tuple = new Tuple<string, int>("Hellow", 1);
            return tuple;
        }
    }
}
