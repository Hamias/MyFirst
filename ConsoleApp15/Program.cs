using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Programm
    {
        static void Main(string[] args)
        {
            A obj = new A(1,5);
            Console.WriteLine(obj.God(""));
            B jvs = new B();
            Console.WriteLine(jvs.c2);
            Console.ReadKey();
            
        }
    }

    class A
    {
        public int a;
        public int b;

        public A()
        {
            a = 1;
            b = 5;
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int God(string gje)
        {

            {
                int x = a;
                do
                {
                    Console.WriteLine(x);
                    x++;

                } while (x < b);
                return x;
            }

        }
    }

    class B : A
        {
            int d;  
            public B(int a, int b):base(a,b)
            {
                
            }
            public B()
            {
             d = 223;
            }

            public int c2
            {
                
                get { return a++ + b*1 + --d; }
            }
        }
        
 }

