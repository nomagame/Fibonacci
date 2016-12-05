using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            int num1 = 0;
            int num2 = 1;

            int inputNum = Convert.ToInt32 ( Console.ReadLine ( ) );
            int totalNum = Fn ( inputNum );
            Console.WriteLine ( totalNum );
        }

        static int Fn(int n )
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException ( );
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return (Fn ( n - 1 ) + Fn ( n - 2 ));
        }
    }
}
