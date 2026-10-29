using System;

namespace KT_Variance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ ВАРИАНТНОСТИ С ВВОДОМ ===");

            Console.Write("Введите кличку собаки для создания Box<Dog>: ");
            string dogName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(dogName))
            {
                dogName = "Бобик"; // значение по умолчанию на случай пустого ввода
            }

            IContainer<Animal> c = new Box<Dog>(new Dog(dogName));

            Animal retrievedAnimal = c.GetItem();
            Console.WriteLine($"Успешно получено из IContainer<Animal>: {retrievedAnimal}");

            // Демонстрация инвариантности классов (пункт 5 задания):
            // Box<Animal> b = new Box<Dog>(new Dog(dogName));


        }
    }
}