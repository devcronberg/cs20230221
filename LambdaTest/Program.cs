using System.Reflection.Metadata.Ecma335;

namespace LambdaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Action test1 = () => { Console.WriteLine("I test1"); };
            Action test1 = () => Console.WriteLine("I test1"); 
            //test1.Invoke();
            test1();

            //Action<int> test2 = (int a) => { Console.WriteLine($"I test2 med {a}"); };
            //Action<int> test2 = (a) => { Console.WriteLine($"I test2 med {a}"); };
            //Action<int> test2 = a => { Console.WriteLine($"I test2 med {a}"); };
            Action<int> test2 = a => Console.WriteLine($"I test2 med {a}"); 
            test2(1);

            //Action<int, double> test3 = (int a, double b) => { Console.WriteLine($"I Test3 med {a} og {b}"); };
            //Action<int, double> test3 = (a, b) => { Console.WriteLine($"I Test3 med {a} og {b}"); };
            Action<int, double> test3 = (a, b) => Console.WriteLine($"I Test3 med {a} og {b}"); 
            test3(1, 5.78);

            //Action<int, double> test3a = (int a, double b) => { 
            //    Console.WriteLine($"I Test3 med {a} og {b}");
            //    Console.Beep();
            //    Console.WriteLine($"I Test3 med {a} og {b}");
            //};
            Action<int, double> test3a = (a, b) => {
                Console.WriteLine($"I Test3 med {a} og {b}");
                Console.Beep();
                Console.WriteLine($"I Test3 med {a} og {b}");
            };
            test3a(1, 5.78);


            //Func<int, int> test4 = (int a) => { return a + 1; };
            //Func<int, int> test4 = (a) => { return a + 1; };
            //Func<int, int> test4 = a => { return a + 1; };
            Func<int, int> test4 = a => a + 1; 
            Console.WriteLine(test4(1));
            
            Func<int, int, int> test5 = (a, b) => a + b;
            Console.WriteLine(test5(1,1));

            //Func<int, bool> test6a = (int a) => { return a < 10; };
            Func<int, bool> test6a = a => a < 10; 
            Predicate<int> test6b = a => a < 10;
            Console.WriteLine(test6a(1));
            Console.WriteLine(test6b(1));


            Console.WriteLine();
            Test1();
            Test2(1);
            Test3(1, 5.76);
            Test3a(1, 5.76);
            Console.WriteLine(Test4(1));
            Console.WriteLine(Test5(1,1));
            Console.WriteLine(Test6(1));

            void Test1()
            {
                Console.WriteLine("I Test1");
            }

            void Test2(int a)
            {
                Console.WriteLine($"I Test2 med {a}");
            }
            
            void Test3(int a, double b)
            {
                Console.WriteLine($"I Test3 med {a} og {b}");
            }

            void Test3a(int a, double b)
            {
                Console.WriteLine($"I Test3 med {a} og {b}");
                Console.Beep();
                Console.WriteLine($"I Test3 med {a} og {b}");
            }

            int Test4(int a)
            {
                return a + 1;
            }

            int Test5(int a, int b)
            {
                return a + b;
            }

            bool Test6(int a)
            {
                return a < 10;
            }
        }
    }
}