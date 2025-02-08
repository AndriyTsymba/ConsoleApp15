using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Backpack
    {
        public string Color { get; private set; }
        public string Brand { get; private set; }
        public string Manufacturer { get; private set; }
        public string Fabric { get; private set; }
        public double Weight { get; private set; }
        public double Volume { get; private set; }
        public List<Item> Contents { get; private set; } = new List<Item>();
        private double currentVolume = 0;

        public event Action<Item> OnItemAdded;

        public Backpack(string color, string brand, string manufacturer, string fabric, double weight, double volume)
        {
            Color = color;
            Brand = brand;
            Manufacturer = manufacturer;
            Fabric = fabric;
            Weight = weight;
            Volume = volume;

            OnItemAdded += delegate (Item item)
            {
                Console.WriteLine($"Додано: {item.Name} (Об'єм: {item.ItemVolume} л)");
            };
        }
        public void AddItem(Item item)
        {
            if (currentVolume + item.ItemVolume > Volume)
            {
                throw new InvalidOperationException($"Неможливо додати {item.Name}, перевищено обсяг рюкзака!");
            }

            Contents.Add(item);
            currentVolume += item.ItemVolume;
            OnItemAdded?.Invoke(item);
        }
        public void ShowContents()
        {
            Console.WriteLine($"Рюкзак {Brand} ({Color}, {Volume} л) містить:");
            foreach (var item in Contents)
            {
                Console.WriteLine($"- {item.Name} (Об'єм: {item.ItemVolume} л)");
            }
        }
    }
    class Item
    {
        public string Name { get; }
        public double ItemVolume { get; }

        public Item(string name, double itemVolume)
        {
            Name = name;
            ItemVolume = itemVolume;
        }
    }
    class Program
    {
        static void Main()
        {
            Backpack myBackpack = new Backpack("Чорний", "Nike", "Nike Inc.", "Поліестер", 1.5, 20);

            try
            {
                myBackpack.AddItem(new Item("Книга", 2));
                myBackpack.AddItem(new Item("Ноутбук", 5));
                myBackpack.AddItem(new Item("Пляшка води", 1.5));
                myBackpack.AddItem(new Item("Одяг", 8));
                myBackpack.AddItem(new Item("Спальний мішок", 10));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            myBackpack.ShowContents();
        }
    }
}