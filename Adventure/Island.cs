using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Island : Environments
    {
        public Island()
        {
            temp = 95;
            animals = "Boars";
            food = "Coconuts";
        }
        public override void Run(Player player)
        {
            Console.WriteLine("You have been air lifted to a remote island in the Caribbean");
            Console.WriteLine("You have chosen a " + player.tool + " for your tool");
            Console.WriteLine("What are you going to do first:" + "\n");
            Console.WriteLine("(1) Set up Shelter");
            Console.WriteLine("(2) Find some food");
            Console.WriteLine("(3) Find some water");
            string doFirst = Console.ReadLine();
            switch (doFirst)
            {
                case "1":
                    Console.WriteLine("You set up your shelter first, which is very important because it is sunny and " + temp + " degrees out.");
                    Alive(player);
                    break;
                case "2":
                    Console.WriteLine("You find a palm tree with " + food + " Unfortunatly, you climb the tree, and get to scared to come down.");
                    Console.WriteLine("You didn't bring your emergency beacon, so you are stuck up there until you pass out.  You fall to you death!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case "3":
                    Console.WriteLine("You found a large puddle of water that looks safe.");
                    Console.WriteLine("It wasn't safe, you have diarrhea for 10 days straight.  You have lost 23 lbs in 10 days, so you decide to call it quits and get rescued.");
                    Console.WriteLine("You are alive and skinny.  After you sickness bout, you start dating a supermodel, get married, have 2 kids, and live happily ever after.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
        public void Alive(Player player)
        {
            Console.WriteLine("You have your shelter set up, now what would you like to do:");
            Console.WriteLine("(1) Find some food");
            Console.WriteLine("(2) Find some water");
            string doSecond = Console.ReadLine();
            switch (doSecond)
            {
                case "1":
                    if (player.tool == "Machete")
                    {
                        Console.WriteLine("You kill the " + animals + " and have plenty of food for the rest of the time you are on the Island");
                    }
                    else
                    {
                        Console.WriteLine("You try to kill a " + animals + ", but you only have a " + player.tool + " so you fail miserably. You are dead!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Alive2(player, doSecond);
                    break;
                case "2":
                    Console.WriteLine("You found a waterfall and have enough water for the rest of the time you are on the Island");
                    Alive2(player, doSecond);
                    break;
                default:
                    Alive(player);
                    break;
            }
        }

        public void Alive2(Player player, string doSecond)
        {
            if (doSecond == "1")
            {
                Console.WriteLine("While you are dragging your " + animals + " back to your shelter, you stumble across a waterfall.");
                Console.WriteLine("You have enough food and water to last the full 21 days, and have built a shelter to keep you out of the cold");
                Console.WriteLine("You survive and meet the rescue team after 21 days.   You WIN!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("While at the waterfall, you decide to go for a swim");
                Console.WriteLine("While you are swimming, a huge log goes over the waterfall and lands on you. You are dead!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
