using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public abstract class Environments
    {
        public int temp;
        public string animals;
        public string food;
        public abstract void Run(Player player);
                 
    }
}
