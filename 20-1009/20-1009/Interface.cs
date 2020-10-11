using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1009
{
    interface IAttack
    { 
        void Breath();
    }

    interface IMove
    {
        void MoveGround();
        void MoveFly();
    }

    class Dragon : IAttack, IMove
    {
        private string name;
        private string type; 

        public Dragon(string name, string type)
        {
            this.name = name; 
            this.type = type;
        } 

        public void Breath()
        {
            Console.WriteLine($"{this.name}의 공격!");
        }

        public void MoveFly()
        {
            Console.WriteLine($"{this.name}가 땅에서 이동");
        }

        public void MoveGround()
        {
            Console.WriteLine($"{this.name}가 하늘에서 이동");
        }
    }
}
