using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run)
            {
                AppSystem appSystem = new AppSystem();
                Reproduction player = new Reproduction();

                player.Onplay(true);

                Console.WriteLine("SPOTFLIX");
                System.Threading.Thread.Sleep(2000);
                appSystem.StartApp();
            }
        }
    }
}
