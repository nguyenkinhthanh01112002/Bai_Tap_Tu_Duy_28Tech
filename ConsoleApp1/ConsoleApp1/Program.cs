using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            List<KeyValuePair<long,int>> list = new List<KeyValuePair<long,int>>();
            list = getList(n);
            for(int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Value == 1)
                {
                    Console.Write(list[i].Key+"*");
                }
                else
                {
                    Console.Write(list[i].Key + "^" + list[i].Value+"*");
                }
            }
            if (list[list.Count - 1].Value == 1)
            {
                Console.Write(list[list.Count - 1].Key);
            }
            else
            {
                Console.Write(list[list.Count - 1].Key + "^" + list[list.Count - 1].Value);
            }
            Console.ReadKey();
        }
        static bool check(long n)
        {
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return n>1;
        }
        static List<KeyValuePair<long,int>> getList(long n)
        {
            List<KeyValuePair<long,int>> keyValuePair = new List<KeyValuePair<long,int>>();

            for(long i = 2; i <= n; i++)
            {
                int dem = 0;
                if (check(i))
                {
                    while(n%i == 0)
                    {
                        dem++;
                        n /= i;
                    }
                    if(dem>=1)
                    {
                        keyValuePair.Add(new KeyValuePair<long, int>(i,dem)) ;
                    }
                }
                if(n==1)
                {
                    break;
                }
            }
            return keyValuePair;
        }
    }
}
