using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public bool genderMale;
        public string tool;
        

        public void ChooseTool()
        {
            Console.WriteLine("Which tool would you like to choose to take with you:" + "\n");
            Console.WriteLine("(1) Firestarter" + "\n");
            Console.WriteLine("(2) Machete" + "\n");
            Console.WriteLine("(3) Cooking Pan" + "\n");
            Console.WriteLine("(4) DuctTape" + "\n");
            string toolChoice = Console.ReadLine();
            switch (toolChoice)
            {
                case "1":
                    tool = "Firestarter";
                    break;
                case "2":
                    tool = "Machete";
                    break;
                case "3":
                    tool = "Cooking Pan";
                    break;
                case "4":
                    tool = "Roll of DuctTape";
                    break;
                default:
                    ChooseTool();
                    break;
            }
        }


    }
}
