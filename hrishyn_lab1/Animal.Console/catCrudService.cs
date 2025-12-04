using System;
using System.Collections.Generic;

namespace Animal.Common
{
    public class CatCrudService
    {
        private readonly Dictionary<Guid, Cat> Cats = new();

        public Guid Create(Cat Cat)
        {
            var id = Guid.NewGuid();
            _Cats[id] = Cat;
            Console.WriteLine($"[CREATE] {Cat.Nickname} add with Id {id}");
            return id;
        }

        public Cat? Read(Guid id)
        {
            return _Cats.TryGetValue(id, out var Cat) ? Cat : null;
        }

        public IEnumerable<Cat> ReadAll()
        {
            return _Cats.Values;
        }

        public void Update(Guid id, Cat newCat)
        {
            if (_Cats.ContainsKey(id))
            {
                _Cats[id] = newCat;
                Console.WriteLine($"[UPDATE] Cat with Id {id} update on{newCat.Nickname}");
            }
        }

        public void Delete(Guid id)
        {
            if (_Cats.Remove(id, out var Cat))
            {
                Console.WriteLine($"[DELETE] {Cat.Nickname} "); 
            }
        }
    }
}
