namespace DelegateTerning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            //t.findTalDelegate = new Func<int, int, int>(Find);
            t.findTalDelegate = FindRigtig;
            t.skrivDelegate = Console.WriteLine;
            t.erSekserDelegate += antal => Console.WriteLine("ANTAL " + antal);
            //t.skrivDelegate += t => File.AppendAllText(@"c:\temp\terning.txt", t);

            t.Skriv();
            t.Ryst();


            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            int[] array = { 5, 1, 4, 1, 6, 7, 10 };
            int findes = System.Array.FindIndex(array, FindesTal);  // 4

            //var array2 = array.ToList();
            //array2.Where()

            bool FindesTal(int a)
            {
                return a == 6;
            }
        }

        static int Find(int a, int b)
        {
            return 6;
        }

        static int FindRigtig(int a, int b)
        {
            return new Random().Next(1, 7);
        }
    }
}