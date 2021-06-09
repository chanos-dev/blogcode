using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_0609
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int idx = 0; idx < 5; idx++)
            {
                //actions.Add(() => Console.WriteLine(idx));

                int temp = idx;
                actions.Add(() => Console.WriteLine(temp));
            }

            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
