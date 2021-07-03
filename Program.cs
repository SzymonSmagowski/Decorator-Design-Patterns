using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();
            IToy centaur = new Centaur("Maximus");
            IToy minotaur = new Minotaur("FatBoy");
            


            Console.WriteLine("-------------------Helmets------------------");

            Decorator warr = new Helmet(warrior);
            Decorator dollD = new Helmet(doll);
            Decorator racer = new Helmet(raceDriver);
            
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(dollD.Summary());
            System.Console.WriteLine(racer.Summary());

            Console.WriteLine("-------------Adding Swords----------------");

             warr = new Sword(warr);
             dollD = new Sword(dollD);
             racer = new Sword(racer);
             System.Console.WriteLine(warr.Summary());
             System.Console.WriteLine(dollD.Summary());
             System.Console.WriteLine(racer.Summary());


            Console.WriteLine("-------------Adding dress----------------");

            dollD = new DottedDress(dollD);
            System.Console.WriteLine(dollD.Summary());


            Console.WriteLine("----------------One toy jump 6 times------------------------");


            warr = new JumpPossibility(warr);
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(warr.Summary());
            System.Console.WriteLine(warr.Summary());


            Console.WriteLine("----------------- Dancing Toys ----------");


            racer = new Breakdance(racer);
            racer = new GangnamStyle(racer);
            dollD = new SoloCapoeira(dollD);
            System.Console.WriteLine(dollD.Summary());
            System.Console.WriteLine(racer.Summary());

            Console.WriteLine("-------------------Story Telling --------------------");

            warr = new ScaryStory(warr);
            System.Console.WriteLine(warr.Summary());




            Console.WriteLine("--------------Adding Minotaur and Centaur-------------------");

            Decorator minD = new SoloCapoeira(minotaur);
            Decorator cenD = new Breakdance(centaur);
            minD = new DottedDress(minD);
            cenD = new FlowerDress(cenD);
            System.Console.WriteLine(minD.Summary());
            System.Console.WriteLine(cenD.Summary());
        }
    }
}
