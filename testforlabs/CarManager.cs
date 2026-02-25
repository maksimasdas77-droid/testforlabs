using System;
using System.Collections.Generic;
using System.Linq;

namespace testforlabs
{
    internal class CarManager
    {
        private List<caritem> cars = new List<caritem>();

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
        public caritem? GetCarByIndex(int index)
        {
            if (index < 1 || index >= cars.Count)
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
            //if (!cars)
            //{     надо доделать эту часть, проверка на существование списка для изменения
            //    Console.WriteLine("список пуст");
            //    return;
            ////}
            if (index < 1 || index > cars.Count) return;
            cars[index -1] = newCar;
        }

    }

}
