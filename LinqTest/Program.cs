//using System.Linq;

namespace LinqTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mappe = new System.IO.DirectoryInfo(@"C:\Users\H-828-INS\source\repos");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Har fundet {filer.Length} i {mappe.Name}");

            var res1 = from fil in filer where 
                        fil.Length > 10000 orderby fil.Name select fil;

            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item.Name + " "+ item.Length);
            //}
            int l = 10000;
            var res2 = filer.Where(i => i.Length > l).ToList();
            Console.WriteLine(res2.FirstOrDefault()?.Name);

        }
    }

    class MinFileInfo
    {
        public string Navn { get; set; }
        public long Længde { get; set; }
    }
}