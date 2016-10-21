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
            GetVideoCallerDetails("897656", PopulateVideoDetails);
            return tuple;
        }

        public static async void GetVideoCallerDetails(string callerDomainId, Action<string> PopulateVideoDetails)
        {
            //Task task=new Task()
            await Task.Run(() => { Thread.Sleep(300); });
            PopulateVideoDetails("Vedio Details");
        }

        public static void PopulateVideoDetails(string vediodetails)
        {
            //popualte data model
        }
    }
}
