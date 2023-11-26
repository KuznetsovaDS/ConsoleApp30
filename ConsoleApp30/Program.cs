using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
        }
        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }
        public void RecordCall(char callType, int minutesG, int minutesM)
        {
            char C = 'C';
            char D = 'D';
            char E = 'E';
            if (callType == C)
                Balance = (Balance - minutesG * 5 - minutesM);
            else if (callType == D)
                if (minutesG > 10)
                    Balance = Balance - minutesM-minutesG * 5 / 2 - 25;
                else
                    Balance = Balance- minutesM- minutesG * 5;
            else if (callType == E)
            {
                if (minutesG <= 5)
                    Balance = Balance - minutesG * 5 / 2;
                else Balance = Balance - minutesG * 10 + 75 / 2;
                if (minutesM <= 5)
                    Balance = Balance - minutesM / 2;
                else Balance = Balance - minutesM * 2 + 15 / 2;
            }
        }
    }
    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова", 500);
            Console.WriteLine("Выберите тарифа для Ивана  из предложенных (введите букву на английском):  C, D, E \n");
            char k = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Выберите тариф для Елены  из предложенных (введите букву на английском):  C, D, E \n");
            char l = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Сколько прговорил Иван по городскому\n");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько прговорил Иван по мобильному\n");
            int m = int.Parse(Console.ReadLine());
            Ivan.RecordCall(k, z, m);
            Console.WriteLine("Сколько прговориа Елена по городскому\n");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько прговориа Елена по по мобильному\n");
            int e = int.Parse(Console.ReadLine());
            Elena.RecordCall(l, y, e);
            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);
        }
    }
}