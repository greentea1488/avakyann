using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void met()
        {
            int n = 30, m = 60;
            int sum = 0;
            for (int i = n; i <= m; i++)
                if (i % 3 == 0)
                {

                    sum += i;
                }
            Console.WriteLine("Сумма чисел кратным 3м в диапазоне от 30 до 60: "+sum);
        }
    }
            
        
}
