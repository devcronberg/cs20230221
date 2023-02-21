using System.Net;

namespace DependencyInjectionTerning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(new MinRandom());
            
            for (int i = 0; i < 15; i++)
            {
                t.Skriv();
                t.Ryst();
            }

            //Console.WriteLine(t.FindTal(1,7));
            //Console.WriteLine(t.FindTal(1, 7));
            //Console.WriteLine(t.FindTal(1, 7));
            //Console.WriteLine(t.FindTal(1, 7));


        }
    }

    public class MinRandom : ITilfældighedGenerator
    {
        public int FindTal(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }
        }
    }


    public class MinMock : ITilfældighedGenerator
    {

        private int v;
        public MinMock(int værdi)
        {
            v = værdi;
        }

        public int FindTal(int min, int max)
        {
            return v;
        }
    }
}