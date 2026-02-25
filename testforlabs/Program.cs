using System;
using System.Globalization;
using System.Text;
using testforlabs.Utills;

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
                Menu.ShowMenu();

                int choice = readclas.ReadValue<int>(int.TryParse);

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("завершение программы");
                        running = false;
                        break;

                    case 1:
                        Console.Clear();
                        manager.ShowAllCars();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        caritem newCar = Utills.Utills.CarInput();
                        manager.AddCar(newCar);
                        break;

                    case 3:
                        Console.Clear();
                        manager.ShowAllCars();
                        if (manager.IsEmpty())
                        {
                            //Console.WriteLine("Список пуст.");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Введите номер автомобиля для удаления: ");
                        int delIndex = readclas.ReadValue<int>(int.TryParse);
                        manager.RemoveCarByIndex(delIndex);
                        break;

                    case 4:
                        Console.Clear();
                        manager.ShowAllCars();
                        if (manager.IsEmpty())
                        {
                            //Console.WriteLine("Список пуст.");
                            Console.ReadLine();
                            break;
                        }

                        Console.Write("Введите номер автомобиля для изменения: ");
                        int updIndex = readclas.ReadValue<int>(int.TryParse);
                        newCar = Utills.Utills.CarInput();
                        manager.UpdateByIndex(updIndex, newCar);
                        break;

                        case 5:
                        Console.Clear();
                        manager.SaveToFile();
                        Console.ReadLine();
                        break;

                        case 6:
                        Console.Clear();
                        manager.LoadFromFile();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Не правильный пункт меню.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
