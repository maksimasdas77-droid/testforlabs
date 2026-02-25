using System;

namespace testforlabs
{
    [Serializable] //обозначение для сериализатора что можно данные записывать по байтам
    public struct caritem
    {
        public string carname;
        public string carnumber;
        public string carowner;

        public caritem(string namecar, string numbercar, string ownercar)
        {
            carname = namecar;
            carnumber = numbercar;
            carowner = ownercar;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Наименование автомобиля: {carname}");
            Console.WriteLine($"Государственный номер: {carnumber}");
            Console.WriteLine($"Владелец автомобиля: {carowner}");
        }
    }
}
