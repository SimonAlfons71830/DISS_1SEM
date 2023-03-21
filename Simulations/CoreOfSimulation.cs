using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISS_1SEM
{

    public abstract class CoreOfSimulation
    {
        public int pocetreplikacii;
        public bool stop { get; set; }

        private Stopwatch stopwatch;
        //vynulovanie hodnot
        public virtual void BeforeReplication() { }
        //hodnoty do grafu
        public virtual void AfterReplication() { }
        //nastavit casomieru
        public virtual void Before() {
            //stopwatch = new Stopwatch();
            //stopwatch.Start();
        }
        //zastavit casomieru
        public virtual void After() {
            //stopwatch.Stop();
            //var time = stopwatch.ElapsedMilliseconds;
        }

        public abstract void Replication();

        public void Simulation(int replications)
        {
            this.stop = false;
            this.Before();
            this.pocetreplikacii = replications;
            for (int i = 0; i < replications; i++) //input z textbox
            {
                if (stop)
                {
                    break;
                }
                this.BeforeReplication();
                this.Replication();
                this.AfterReplication();
            }
            this.After();

        }
    }
}
