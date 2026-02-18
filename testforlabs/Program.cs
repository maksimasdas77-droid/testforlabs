using System;
using System.Globalization;
using System.Text;

namespace testforlabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");

            CarManager manager = new CarManager();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Показать автомобили");
                Console.WriteLine("2. Добавить автомобиль");
                Console.WriteLine("3. Удалить автомобиль");
                Console.WriteLine("4. Изменить автомобиль");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                int choice = myclass.ReadValue<int>(int.TryParse);

                switch (choice)
                {
                    case 0:
                        running = false;
                        break;

                    case 1:
                        Console.Clear();
                        manager.ShowAllCars();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Введите наименование авто: ");
                        string name = Console.ReadLine();

                        Console.Write("Введите гос. номер: ");
                        string number = Console.ReadLine();

                        Console.Write("Введите владельца: ");
                        string owner = Console.ReadLine();

                        manager.AddCar(new caritem(name, number, owner));
                        break;

                    case 3:
                        Console.Clear();
                        //Console.Write("Введите гос. номер для удаления: ");
                        //string delnum = Console.ReadLine();
                        //manager.RemoveCar(delnum);
                        manager.ShowAllCars();
                        Console.Write("Введите номер автомобиля для удаления: ");
                        int delIndex = myclass.ReadValue<int>(int.TryParse);
                        manager.RemoveCarByIndex(delIndex);
                        break;

                    case 4:
                        Console.Clear();
                        //Console.Write("Введите гос. номер для изменения: ");
                        //string oldnum = Console.ReadLine();

                        //Console.Write("Введите новое название авто: ");
                        //string newname = Console.ReadLine();

                        //Console.Write("Введите новый гос. номер: ");
                        //string newnumber = Console.ReadLine();

                        //Console.Write("Введите нового владельца: ");
                        //string newowner = Console.ReadLine();

                        //manager.UpdateCar(oldnum, new caritem(newname, newnumber, newowner));
                        manager.ShowAllCars();
                        Console.Write("Введите номер автомобиля для изменения: ");
                        int updIndex = myclass.ReadValue<int>(int.TryParse);
                        Console.Write("Введите новое название авто: ");
                        string newname = Console.ReadLine();
                        Console.Write("Введите новый гос. номер: ");
                        string newnumber = Console.ReadLine();
                        Console.Write("Введите нового владельца: ");
                        string newowner = Console.ReadLine();
                        manager.UpdateByIndex(updIndex, new caritem(newname, newnumber, newowner));
                        break;
                }
            }
        }
    }
}
