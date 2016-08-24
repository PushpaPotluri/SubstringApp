using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SubstringApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string number = "20000";
            long[] l10SubstringsArray = GetAll10Substrings(number).Result;
            
            foreach(var n in l10SubstringsArray)
                Console.WriteLine(n);

            Console.Read();
        }

        public static async Task<long[]> GetAll10Substrings(string number)
        {
            List<long> i10SubstringArray = new List<long>();
            long no;
            
            if (!long.TryParse(number, out no))
                return i10SubstringArray.ToArray();

            Parallel.For(0, no, n =>
            {
                if (Is10Substring(n.ToString()).Result)
                    i10SubstringArray.Add(n);
            });

            return i10SubstringArray.ToArray();
        }

        public static async Task<bool> Is10Substring(string no)
        {
            bool b10Substring = false;
            int i;
            for (i = 0; i < no.Length; i++)
            {
                int sum = 0;
                int j;
                b10Substring = false;
                for (j = i; j < no.Length; j++)
                {
                    int digit = 0;
                    int.TryParse(no[j].ToString(), out digit);
                    sum += digit;
                    if (sum > 10)
                    {
                        b10Substring = b10Substring == true;
                        break;
                    }

                    b10Substring = (sum == 10);
                }

                if (j == no.Length || b10Substring == false)
                {
                    break;
                }
            }

            return b10Substring;
        }
    }
}
