using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Оголосіть два делегати: UseOperation, GetGreeting.
Перший делегат посилається на функцію, яка в якості параметрів приймає два значення типу int і повертає
деяке ціле число.
Другий делегат посилається на метод без параметрів, який нічого не повертає.
 Створіть методи без параметрів GoodMorning, GoodDay, GoodEvening і GoodNight, при виклику яких
виводиться текст «Доброго ранку!», «Добрий день!», «Добрий вечір!» і «Доброї ночі!». Якщо відомо, що
властивість DateTime.Now.Hour повертає кількість годин поточного часу, то напишіть програму, в якій, за
допомогою делегата GetGreeting, запускається один з написаних вами методів, в залежності від поточного
значення часу.
 Створіть методи для обчислення суми, різниці, добутку, частки двох цілих чисел.
Використовуючи делегат UseOperation для виклику описаних в попередньому пункті методів, напишіть
програму, яка запитує у користувача два цілих числа і операцію, яку необхідно провести. Виводить відповідний
результат. 
*/
namespace lab8_4
{
    class Program
    {
        delegate int UseOperation(int p1, int p2);
        delegate void GetGreeting();
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            GetGreeting gg;
            if (hour <= 4 && hour >= 23) gg = GoodNight;
            else if (hour <= 10 && hour >= 5) gg = GoodMorning;
            else if (hour <= 15 && hour >= 11) gg = GoodDay;
            else gg = GoodEvening;
            gg(); 
            Dictionary<string, UseOperation> Op = new Dictionary<string, UseOperation>
            {
                { "+", Sum },
                { "-", Minus },
                { "*", Multiply },
                { "/", Division },
            };
            int a, b;
            string operation;
            do
            {
                Console.WriteLine("Оберіть операцію +-*/ :");
                operation = Console.ReadLine();
                if (Op.ContainsKey(operation))
                {
                    break;
                }
                Console.WriteLine("Ця операція неможлива");
            } while (true);

            Console.WriteLine("Введіть два числа:");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a " + operation + " b = " + Op[operation](a, b));
        
        Console.ReadKey();
        }
        public static void GoodMorning()
        {
            Console.WriteLine("Доброго ранку!");
        }
        public static void GoodDay()
        {
            Console.WriteLine("Доброго дня!");
        }
        public static void GoodEvening()
        {
            Console.WriteLine("Добрий вечір!");
        }
        public static void GoodNight()
        {
            Console.WriteLine("Доброї ночі!");
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
