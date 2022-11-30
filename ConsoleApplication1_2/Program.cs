using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if ((9 < num && num < 100) || (-9>num && num >-99))
                {
                    string a = num.ToString();
                    int sum = 0;
                    if (num > 0)
                    {
                        sum = Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]);
                    }
                    else { sum = Convert.ToInt32(a[1]) + Convert.ToInt32(a[2]); };
                    if (sum % 3 == 0) { Console.WriteLine("Сумма цифр кратна 3"); }
                    else Console.WriteLine("Сумма цифр не кратна 3 ");
                }
                else Console.WriteLine("Некорректный ввод данных");
            }
            catch { Console.WriteLine("Некорректный ввод данных"); }
            Console.ReadKey();
        }

    }
}
