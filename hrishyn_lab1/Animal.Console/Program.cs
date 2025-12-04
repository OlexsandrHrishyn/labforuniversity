using Animal.Common;
using System;

namespace Animal.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var service = new CatCrudService();

var Cat1 = new Cat("Cat", "Mammal", "Carnivora", "Bobik") { Breed = "Dachshund" };
    var Cat2 = new Cat("Cat", "Mammal", "Carnivora", "Sharik") { Breed = "Shepherd" };

         var id1 = service.Create(Cat1);
                var id2 = service.Create(Cat2);

                    Console.WriteLine("\n[READ ALL]");
            foreach (var d in service.ReadAll())
                    Console.WriteLine($" - {d.Nickname}, {d.Breed}");

            var newCat = new Cat("Cat", "Mammal", "Carnivora", "Bobik") { Breed = "Corgi" };
            service.Update(id1, newCat);

            service.Delete(id2);

            Console.WriteLine("\n[READ ALL after delete]");
            foreach (var d in service.ReadAll())
                Console.WriteLine($" - {d.Nickname}, {d.Breed}");
        }
    }
}
