using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DISS_1SEM
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        public ManualResetEvent pauseEvent1 = new ManualResetEvent(true);
        private Thread thread2;
        public ManualResetEvent pauseEvent2 = new ManualResetEvent(true);
        RouteSimulation sim;
        ProbabilitySimulator simulation;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            simulation = new ProbabilitySimulator(this);

            sim = new RouteSimulation(this);
        }

        private void startFirstSimulation()
        {
            int numberOfReplications = Convert.ToInt32(textBox1.Text);
            this.Invoke((MethodInvoker)delegate { label3.Text = "Started simulation."; });
            sim.Simulation(numberOfReplications);
        }

        private void startSecondSimulation() 
        {
            int numberOfReplications = Convert.ToInt32(textBox2.Text);
            this.Invoke((MethodInvoker)delegate { label4.Text = "Started simulation."; });
            simulation.Simulation(numberOfReplications);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time_chart.Series["waiting time"].Points.Clear();
            time_label.Text = null;
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Provide number of desired replications.");
                return;
            }
            thread1 = new Thread(new ThreadStart(this.startFirstSimulation));
            thread1.IsBackground=true;
            thread1.Start();
            
        }

        public void UpdateChart_time(double waitingtime, int donereplications) 
        {
            this.Invoke((MethodInvoker)delegate
            {
                label3.Text = "In progress...";
                time_chart.Series["waiting time"].Points.AddXY(donereplications,waitingtime);
                time_label.Text = waitingtime.ToString("0.######");
                //time_chart.Update();
                time_label.Update();
            });
        }

        public void UpdateChart_probability(double prob, int donereplication) 
        {
            this.Invoke((MethodInvoker)delegate
            {
                label4.Text = "In progress...";
                probability_label.Text = prob.ToString("0.######");
                probability_chart.Series["probability"].Points.AddXY(donereplication,prob);
                //probability_chart.Update();
                //probability_label.Update();
            });
        }

        public void UpdateLabel3(double lastTime) {
            label3.Text = "Finished.";
            time_label.Text = lastTime.ToString("0.######");

        }
        public void UpdateLabel4(double lastProb)
        {
            label4.Text = "Finished.";
            probability_label.Text = lastProb.ToString("0.######");
        }

        private void terminate_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start2_button_Click(object sender, EventArgs e)
        {
            probability_chart.Series["probability"].Points.Clear();
            probability_label.Text = null;
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Provide number of desired replications.");
                return;
            }
            thread2 = new Thread(new ThreadStart(this.startSecondSimulation));
            thread2.IsBackground = true;
            thread2.Start();
        }

        private void stop1_button_Click(object sender, EventArgs e)
        {
            pauseEvent1.Reset();
            sim.stop = true;
        }

        private void continue1_button_Click(object sender, EventArgs e)
        {
            pauseEvent1.Set();
        }

        private void stop2_button_Click(object sender, EventArgs e)
        {
            pauseEvent2.Reset();
            simulation.stop = true;
        }

        private void stop3_button_Click(object sender, EventArgs e)
        {
            pauseEvent2.Set();
        }
    }
}
