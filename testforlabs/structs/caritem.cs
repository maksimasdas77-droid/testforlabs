using System;
using System.Security.Cryptography.X509Certificates;

namespace testforlabs
{
    [Serializable] //обозначение для сериализатора что можно данные записывать по байтам
    public struct caritem
    {
        public string carname;
        public string carnumber;
        public string carowner;

        public DateTime CreatedAt; //дата добавления
        public DateTime UpdateAt; //дата последнего обновления

        public caritem(string namecar, string numbercar, string ownercar)
        {
            carname = namecar;
            carnumber = numbercar;
            carowner = ownercar;
            
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Наименование автомобиля: {carname}");
            Console.WriteLine($"Государственный номер: {carnumber}");
            Console.WriteLine($"Владелец автомобиля: {carowner}");
            Console.WriteLine($"Добавлен: {CreatedAt}");
            Console.WriteLine($"Последнее изменение: {UpdateAt}");
        }
    }
}
