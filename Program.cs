using System;
using System.Linq;
using System.Text;

namespace BoxingUnboxingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример упаковки (Boxing):

            int i = 123;      // Инициализируем переменную "i";
            object obj1 = i; // (Boxing)- копируем значение i в значение object obj;

            // Пример распаковки (Unboxing):

            //int i = 123;        // "i" здесь является значением типа;
            //object obj1 = i;   //  упаковка (Boxing): "i" в "obj1";
            int obj2 = (int)obj1; // распаковка (Unboxing): " obj1" в "obj2".

        }
    }
}
