using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Canada : Environments    
    {
        public Canada()
        {
        temp = 40;
        animals = "Bears";
        food = "Berries";
        }

        public override void Run(Player player)
        {
            Console.WriteLine("You have been air lifted to an island in Northern Canada");
            Console.WriteLine("You have chosen a " + player.tool + " for your tool");
            Console.WriteLine("What are you going to do first:" + "\n");
            Console.WriteLine("(1) Set up Shelter");
            Console.WriteLine("(2) Find some food");
            Console.WriteLine("(3) Find some water");
            string doFirst = Console.ReadLine();
            switch (doFirst)
            {
                case "1":
                    Console.WriteLine("You set up your shelter first, which is very important because it is " + temp + " degrees outside");
                    Alive(player);
                    break;
                case "2":
                    Console.WriteLine("You are looking around for " + food + "when a " + animals + "attacks you and eats you!");
                    Environment.Exit(0);
                    break;
                case "3":
                    Console.WriteLine("You found a large source water, but you were looking at your beautiful reflection in the water and fell in and died of Hypothermia!");
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
                            Console.WriteLine("You kill the " + animals + "and have plenty of food for the rest of the time you are in Canada");
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
                    Console.WriteLine("You found a cold running stream and have enough water for the rest of the time you are in Canada");
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
                Console.WriteLine("While you are dragging your " + animals + " back to your shelter, you  stumble across a cold running stream.");
                Console.WriteLine("You have enough food and water to last the full 21 days, and have built a shelter to keep you out of the cold");
                Console.WriteLine("You survive and meet the rescue team after 21 days.   You WIN!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("While at the stream, you see a bear looking for salmon. You decide to try to swim across the stream");
                Console.WriteLine("You get swept up in the current and drown in the freezing water. You are dead!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
