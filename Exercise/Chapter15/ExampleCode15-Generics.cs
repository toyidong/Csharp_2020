using System;

namespace Chapter15
{
    public class Dog
    {

    }

    public class Cat
    {

    }

    public class AnimalShelter<T, U> 
                            where T: Dog
                            where U: Cat
    {
        private const int DefaultPlaceCount = 20;

        private object[] animalList;
        private int usedPlaces;

        public AnimalShelter() : this(DefaultPlaceCount)
        {

        }
        public AnimalShelter(int placeCount)
        {
            this.animalList = new object[placeCount];
            this.usedPlaces = 0;
        }

        public void Shelter(object newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public Object Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            Object releasedAnimal = this.animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default(Object);
            this.usedPlaces--;
            return releasedAnimal;
        }

        public void ShelterPrint()
        {
            foreach (object x in this.animalList)
            {
                if (object.Equals(x, null)) break;
                Console.WriteLine(x);

            }
        }
    }
    public class Test
    {
        public static void Main()
        {
            AnimalShelter<Dog, Cat> shelter = new AnimalShelter<Dog, Cat>();
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            // Dog d = (Dog)shelter.Release(1); // Release the second dog
            // Console.WriteLine(d);
            // d = (Dog)shelter.Release(0); // Release the first dog
            // Console.WriteLine(d);
            // d = (Dog)shelter.Release(0); // Release the third dog
            // Console.WriteLine(d);
            // d = shelter.Release(0); // Exception: invalid cell index
            Cat cat1 = new Cat();
            shelter.Shelter(cat1);
            shelter.ShelterPrint();
        }
    }
}