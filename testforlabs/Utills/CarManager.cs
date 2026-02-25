using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace testforlabs
{
    internal class CarManager
    {
        private List<caritem> cars = new List<caritem>();

        private const string FileName = @"D:\projekts\testforlabs\cars.bin"; //объявление абсолютного пути к файлу

        //части кода для записи и чтения бинарного файла

        public void SaveToFile() //запись в файл
        {
            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            File.WriteAllText(FileName, json);
            Console.WriteLine("Данные успешно сохранены.");
        }

        public void LoadFromFile()
        {
            if (!File.Exists(FileName))
            {
                Console.WriteLine("Файл не найден");
                return;
            }
            string json = File.ReadAllText(FileName);
            cars = JsonConvert.DeserializeObject<List<caritem>>(json);
            Console.WriteLine("Данные успешно загружены.");
        }

        public void AddCar(caritem car)
        {
            cars.Add(car);
        }

        public void RemoveCar(string number) //метод сейчас не используется, переписано все по индексам
        {
            cars.RemoveAll(c => c.carnumber == number);
        }

        public void UpdateCar(string number, caritem newCar)
        {
            int index = cars.FindIndex(c => c.carnumber == number); //мето не используется, пеерешли на индексы
            if (index != -1)
                cars[index] = newCar;
        }

        public void ShowAllCars()
        {
            if (!cars.Any())
            {
                Console.WriteLine("Список автомобилей пуст.");
                return;
            }

            int index = 1;
            foreach (var car in cars)
            {
                Console.Write($"{index}. ");
                car.DisplayAccountInfo();
                Console.WriteLine();
                index++;
            }
        }
        public caritem? GetCarByIndex(int index) //проверить на актуальность этот метод
        {
            if (index < 1 || index > cars.Count)
            return null;
            return cars[index - 1];
        }
        public void RemoveCarByIndex(int index)
        {
            if (index < 1 || index > cars.Count) return;
            cars.RemoveAt(index - 1);
        }
        public void UpdateByIndex(int index, caritem newCar)
        {
            if (!cars.Any())
            {
                Console.WriteLine("список пуст");
                return;
            }
                if (index < 1 || index > cars.Count) return;
                newCar.CreatedAt = cars[index -1].CreatedAt;
                newCar.UpdateAt = DateTime.Now;
            cars[index -1] = newCar;
        }
        public bool IsEmpty() //для проверки на наличие списка в мейне
        {
            return !cars.Any();
        }
        


    }

}
