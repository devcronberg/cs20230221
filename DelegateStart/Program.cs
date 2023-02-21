namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maskine m = new Maskine();
            ////m.log = new LogDelegate(Console.WriteLine);
            ////m.log = new Action<string>(MinLog2);
            ////m.log = new Action<string>(txt => File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"));
            //m.log = txt => File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");


            //m.Start();
            //m.Stop();

            List<int> tal = new List<int>() { 5, 1, 4, 10 };
            //foreach (var item in tal)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();


            //tal.ForEach(S);


            tal.ForEach(Console.WriteLine);
            Console.WriteLine();
            tal.Where(i => i < 10).OrderBy(i => i).ToList().ForEach(Console.WriteLine);





        }

        //static void S(int a) {
        //    Console.Beep();
        //    Console.WriteLine(a);
        //}

        static void MinLog1(string txt)
        {
            Console.WriteLine(txt);
        }
        //static void MinLog2(string txt)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        //}

        static void MinLog3(string txt)
        {
            Console.WriteLine("*** " + txt);
            Console.Beep();
        }
    }









    //delegate void LogDelegate(string txt);
    //class LogDelegate { }

    class Maskine
    {

        //public LogDelegate log;
        public Action<string> log;

        public void Start()
        {
            Log("Nu starter jeg");
        }
        public void Stop()
        {
            Log("Nu stopper jeg");
        }

        private void Log(string txt)
        {
            string t = DateTime.Now.ToLongTimeString();
            if (log != null)
                log.Invoke(t + " " + txt);


        }
    }


}