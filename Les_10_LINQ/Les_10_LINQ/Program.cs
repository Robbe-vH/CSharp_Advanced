using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Les_10_LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int OwnerId { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Id = 1, Age = 22, Name = "Barry" },
                new Person() { Id = 2, Age = 31, Name = "Kees" },
                new Person() { Id = 3, Age = 46, Name = "Piet" },
            };

            List<Pet> pets = new List<Pet>()
            {
                new Pet() { Id = 1, Name = "Fifi", Type = "Bird", OwnerId = 2 },
                new Pet() { Id = 2, Name = "Minoes", Type = "Cat", OwnerId = 1 },
                new Pet() { Id = 3, Name = "Bello", Type = "Dog", OwnerId = 1 },
                new Pet() { Id = 4, Name = "Veertje", Type = "Bird", OwnerId = 3 },
                new Pet() { Id = 5, Name = "Pluisje", Type = "Cat", OwnerId = 3 },
                new Pet() { Id = 6, Name = "Tijger", Type = "Cat", OwnerId = 2},
                new Pet() { Id = 7, Name = "Boris", Type = "Dog", OwnerId = 2}
            };

            //Console.WriteLine(pets.First().Name);

            //people.ForEach(x => Console.WriteLine(x.Name));

            //SELECT 
            List<int> ages = people.Select(x => x.Age).ToList();
            Console.WriteLine("avg age: " + ages.Average());

            //WHERE
            List<Pet> barrysPets = pets.Where(x => x.OwnerId.Equals(1)).ToList();
            barrysPets.ForEach(x => Console.WriteLine(x.Name));


            //SELECT + WHERE
            List<string> barrysPetNames = pets.Where(x => x.OwnerId.Equals(1)).Select(x => x.Name).ToList();
            barrysPetNames.ForEach(x => Console.WriteLine(x));

            //ORDERBY
            List<Pet> sortedPets = pets.OrderBy(x => x.Name).ToList();
            List<Person> sortedPeople = people.OrderBy(x => x.Name).ThenBy(x => x.Age).ToList();
            sortedPets.ForEach(x => Console.WriteLine(x.Name));
            sortedPeople.ForEach(x => Console.WriteLine(x.Name));

            //GROUPBY
            var petsPerGroup = pets.GroupBy(x => x.Type);
            foreach (var group in petsPerGroup)
            {
                foreach (Pet pet in group)
                {
                    Console.WriteLine($"{group.Key} - {pet.Name}");
                }
            }

            //JOIN
            var joinedPeopleWithPets = people.Join(
                pets,                   //verzameling om te joinen
                person => person.Id,    // waarde om te mappen voor eerste verzameling
                pet => pet.OwnerId,     // waarde om te mappen voor tweede verzameling
                (person, pet) => new { Owner = person, Pet = pet }  //selecten van 2 objecten, worden geprojecteerd naar een nieuw object
                );

            var peopleWithPetsQuery = from person in people
                                      join pet in pets
                                      on person.Id equals pet.OwnerId
                                      select new { Owner = person, Pet = pet };

            foreach (var personWithPet in peopleWithPetsQuery)
            {
                Console.WriteLine($"{personWithPet.Owner.Name} heeft {personWithPet.Pet.Name}");
            }
            Console.Read();
        }
    }
}