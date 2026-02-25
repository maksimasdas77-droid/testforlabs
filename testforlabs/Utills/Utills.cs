using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace testforlabs.Utills
{
    internal class Utills
    {
        public static caritem CarInput()
        {
            Console.Write("Введите наименование автомобиля: ");
            string name = Console.ReadLine();

            Console.Write("Введите гос.номер автомобиля: ");
            string number = Console.ReadLine();

            Console.Write("Введите владельца автомобиля: ");
            string owner = Console.ReadLine();

            return new caritem(name, number, owner);
        }
    }
}
