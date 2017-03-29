using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame7
{
    class RunExample
    {
       public static void Main()
        {
            Console.WriteLine("Add your player");
            Game newgame=new Game();
            newgame.AddPlayer();
            Console.ReadLine();

        }
    }
}
