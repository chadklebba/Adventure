using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Adventure
    {
        public string environment;
        Environments place;
       
            public Adventure(Player player)
        {
            RandEnvironment();
            place.Run(player);        
        }
      
        void RandEnvironment()
            {
            Random rand = new Random();
            int answer = (rand.Next(1, 4));
            switch (answer)
            {
                case 1:
                    environment = "Canada";
                    place = new Canada();
                    break;
                case 2:
                    environment = "Jungle";
                    place = new Jungle();
                    break;
                case 3:
                    environment = "Island";
                    place = new Island();
                    break;
                default:
                    RandEnvironment();
                    break;

            }
            }


    }
}
