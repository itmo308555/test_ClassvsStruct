using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    [MemoryDiagnoser]
    public class Program
    {
        [Benchmark]
        public void ListOfClassObjectsTest()
        {
            const int length = 1000000;
            var items = new List<PointClass>(length);
            for (int i = 0; i < length; i++)
            {
                items.Add(new PointClass()
                {
                    X = i,
                    Y = i
                });
            }
        }

        [Benchmark]
        public void ListOfStructsObjectTest()
        {
            const int length = 1000000;
            var items = new List<PointStruct>(length);
            for (int i = 0; i < length; i++)
            {
                items.Add(new PointStruct()
                {
                    X = i,
                    Y = i
                });
            }
        }
        public static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<Program>();
           // Console.ReadLine();
        }
    }
}
