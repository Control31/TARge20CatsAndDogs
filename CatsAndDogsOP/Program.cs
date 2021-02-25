using System;

namespace CatsAndDogsOP
{
    class Program
    {

        class Pet
        {
            public string name;
            public string color;
            public int levelOfHappiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Happiness level: {levelOfHappiness}");
            }
        }
        class Dog : Pet
        {
            public Dog(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHappiness = 0;
            }
            public void WaveTail()
            {
                levelOfHappiness+=1;
            }
            public bool Bark()
            {
                Console.WriteLine("woof-woof");
                return true;
            }
        }
        class Cat : Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHappiness = 10;
            }
            public void HearTheDog()
            {
                levelOfHappiness = 0;
            }
            public void Hiss()
            {
                Console.WriteLine("Hsssss");
            }
        }
        static void Main(string[] args)
        {
            Dog Doggy = new Dog("Doge", "brown");
            Cat Kitty = new Cat("Cate", "black");

            Doggy.PrintPetInfo();
            Kitty.PrintPetInfo();

            for (int i = 0; i < 10; i++)
            {
                Doggy.WaveTail();
            }

            if (Doggy.Bark())
            {
                Kitty.HearTheDog();
            }
            if(Kitty.levelOfHappiness == 0)
            { 
                Kitty.Hiss(); 
            }
        }
    }
}
