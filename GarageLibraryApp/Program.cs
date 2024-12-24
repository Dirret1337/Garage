using System;
using GarageLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект гаража
        Garage garage = new Garage
        {
            Name = "Central Garage",
            Address = "Стараватутинский дом 127"
        };

        // Добавляем автомобили
        garage.Cars.Add(new Car { Owner = "Bmw", Number = "A127BC" });
        garage.Cars.Add(new Car { Owner = "Audi", Number = "B436DE" });
        garage.Cars.Add(new Car { Owner = "Xiaomi", Number = "C739FG" });

        // Выводим информацию о всех автомобилях
        garage.ShowAll();
    }
}
