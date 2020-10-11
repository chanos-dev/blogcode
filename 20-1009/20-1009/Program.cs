using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog("바둑이", "진돗개");
            animals[1] = new Cat("초롱이", "페르시안");
            animals[2] = new Pigeon("구구", "바위");

            foreach (Animal animal in animals)
            {
                animal.GetInfo();
                animal.Sound();
                animal.Run();
                animal.Fly();
            }

            Dragon dragon = new Dragon("용용이", "아이스드래곤");
            dragon.Breath();
            dragon.MoveFly();
        }
    }
}
