using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISS_1SEM
{
    internal class ProbabilitySimulator : CoreOfSimulation
    {
        SeedGenerator generator;
        Form1 form;
        private double duration;
        private int inTime;
        private int doneReplications;
        Routes routes;
        public ProbabilitySimulator(Form1 form)
        {
            this.form = form;
            generator = new SeedGenerator();
            routes = new Routes(generator);
            
        }
        
        public override void BeforeReplication()
        {
            //this.form.pauseEvent2.WaitOne();
            this.duration = 0;
            //not implemented yet
        }

        public override void AfterReplication()
        {
            if (this.doneReplications >= (this.pocetreplikacii * 0.3))
            {
                if (this.doneReplications % ((this.pocetreplikacii * 0.7) / 1000) == 0)
                {
                    double probabilityOfMakingItInTime = (double)this.inTime / (double)(this.doneReplications);
                    form.UpdateChart_probability(probabilityOfMakingItInTime, this.doneReplications);
                }
            }
        }

        public override void Before()
        {
            this.pocetreplikacii = 0;
            this.duration = 0;
            this.doneReplications = 0;
            this.inTime = 0;

        }

        public override void After()
        {
            var prob = (double)this.inTime / (double)(this.doneReplications);
            form.Invoke((MethodInvoker)delegate { form.UpdateLabel4(prob); });
        }

        public override void Replication()
        {
            //vyrazia 7:40 a podari sa im prist do 13:00 -> 320 min
            //D_E, E_C a C_M
            this.duration = (routes.ROUTE_D_E() + routes.ROUTE_E_C() + routes.ROUTE_C_M());
            if (this.duration < 320) //do 13:00 -> 12:59
            {
                this.inTime++;
            }
            this.doneReplications++;

        }

    }
}
