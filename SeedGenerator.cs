using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISS_1SEM
{
    public class SeedGenerator
    {
        Random seed = new Random();
        public SeedGenerator()
        {
            
        }
        public int generate_seed()
        {
            return seed.Next();
        }

        /*public List<int> generate_seeds(int count) 
        { 
            List<int> list_of_seeds = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list_of_seeds.Add(seed.Next());
            }
            return list_of_seeds;
        }*/
    }
}
