using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CriticalSectionProblemExample
{
    class Program
    {

        static void Main(string[] args)
        {
            ReaderWriterLock myResultLock = new ReaderWriterLock();
            List<string> testString1 = new List<string>
            {
                "Sohil","Mansuri","SM"
            };

            List<string> testString2 = new List<string>
            {
                "Sohil","Mansuri","SM"
            };

            Task.Factory.StartNew(() =>
            {
                foreach (var item in testString1)
                {
                    if (!myResultLock.IsReaderLockHeld)
                    {
                        myResultLock.AcquireReaderLock(Timeout.Infinite);
                        Console.WriteLine($"from testring1 {item}");
                        myResultLock.ReleaseReaderLock();
                    }
                }
            });

            Task.Factory.StartNew(() =>
            {
                foreach (var item in testString1)
                {
                    if (!myResultLock.IsReaderLockHeld)
                    {
                        myResultLock.AcquireReaderLock(Timeout.Infinite);
                        Console.WriteLine($"from testring2 {item}");
                        myResultLock.ReleaseReaderLock();
                    }
                }
            });

            Task.WaitAll();
            Console.ReadLine();
        }
    }

    
}
