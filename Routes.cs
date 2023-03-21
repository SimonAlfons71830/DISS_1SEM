using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DISS_1SEM
{
    internal class Routes
    {
        EmpiricalDistribution route_C_M;
        ContinuousEven route_d_e;
        EmpiricalDistribution route_E_C;
        DiscreteEven route_A_B;
        public Routes(SeedGenerator generator)
        {
            route_A_B = new DiscreteEven(39, 64, generator);

            (int, int, double)[] route_c_m = {
            (3, 10, 0.2),
            (11, 20, 0.2),
            (21, 34, 0.3),
            (35, 52, 0.1),
            (53, 59, 0.15),
            (60, 95, 0.03),
            (96, 110, 0.02)
            };
            route_C_M = new EmpiricalDistribution(route_c_m, generator);
            route_d_e = new ContinuousEven(19, 36, generator);
            
            (int, int, double)[] route_e_c = {
            (230, 243, 0.3),
            (244, 280, 0.5),
            (281, 490, 0.2) //350 -> 490
            };

            route_E_C = new EmpiricalDistribution(route_e_c, generator);
        }
        //diskretne rovnomerne
        public int ROUTE_A_B()
        {
            return route_A_B.Next();
        }

        //deterministicke
        public int ROUTE_B_C()
        {
            return 57;
        }
        //diskretne empiricke
        public int ROUTE_C_M()
        {
            return route_C_M.Next();
        }
        //spojite rovnomerne
        public double ROUTE_D_E()
        {
            return route_d_e.Next();
        }
        //diskretne empiricke
        public int ROUTE_E_C()
        {
            return route_E_C.Next();
        }
    }
    
}
