using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Створіть методи без параметрів GoodMorning, GoodDay, GoodEvening і GoodNight, при виклику яких
виводиться текст «Доброго ранку!», «Добрий день!», «Добрий вечір!» і «Доброї ночі!». Якщо відомо, що
властивість DateTime.Now.Hour повертає кількість годин поточного часу, то напишіть програму, в якій, за
допомогою делегата GetGreeting, запускається один з написаних вами методів, в залежності від поточного
значення часу.*/
namespace lab8_4
{
    class Class1
    {
        public static void GoodMorning()
        {
            Console.WriteLine("Доброго ранку!");
        }
        public static void GoodEvening()
        {
            Console.WriteLine("Добрий вечір!");
        }
        public static void GoodNight()
        {
            Console.WriteLine("Доброї ночі!");
        }



    }
}
