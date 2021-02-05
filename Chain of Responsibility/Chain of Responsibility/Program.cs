using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму: ");
            int sum;
            while (!Int32.TryParse(Console.ReadLine(), out sum) || sum <= 0)
            {
                Console.WriteLine("Сумма должна быть натуральным числом попробуйте еще раз:");
            }

            int[] faceValues = { 50, 20, 10, 5, 2, 1, };
            List<Banknote> banknotes = new List<Banknote>();
            foreach (int nominal in faceValues)
            {
                if (nominal <= sum)
                {
                    banknotes.Add(new Banknote(faceValue: nominal, requiredAmnt: sum / nominal));
                    sum %= nominal;
                }
            }

           banknotes.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
        
    }
}
