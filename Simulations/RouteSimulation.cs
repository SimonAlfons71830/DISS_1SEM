using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISS_1SEM
{
    internal class RouteSimulation : CoreOfSimulation
    {
        SeedGenerator generator;
        Form1 form;
        private double duration;
        private int doneReplications;
        private int waitingCount;
        Routes routes;
        public RouteSimulation(Form1 form) 
        {
            this.form = form;
            this.duration = 0;
            generator = new SeedGenerator();
            routes = new Routes(generator);
        }
        

        public override void BeforeReplication()
        {
            //this.form.pauseEvent1.WaitOne();
            //not implemented yet
        }

        public override void AfterReplication()
        {
            if (this.doneReplications >= (this.pocetreplikacii * 0.3))
            {
                if (this.doneReplications % ((this.pocetreplikacii*0.7)/1000) == 0)                {
                    // sucet kladneho cakanie / pocet vsetkych replikacii (vratane zaporneho cakania)
                    var approximate_time = duration / this.doneReplications;
                    form.UpdateChart_time(approximate_time, doneReplications);
                }
            }
        }

        public override void Before()
        {
            this.pocetreplikacii = 0;
            this.duration = 0;
            this.doneReplications = 0;
        }

        public override void After()
        {
            var lasttimevalue = duration / this.doneReplications;
            form.Invoke((MethodInvoker)delegate { form.UpdateLabel3(lasttimevalue); });
        }

        public override void Replication()
        {
            //A-B, B-C, C-M o 10:55 -> do 13:00 je 125 min
            var cakanie = (routes.ROUTE_A_B() + routes.ROUTE_B_C() + routes.ROUTE_C_M()) - 125;
            //cakanie >= 0 ?  cakanie : 0;
            if (cakanie > 0)
            {
                this.duration += cakanie;
            }
            this.doneReplications++;
        }

    }
}
