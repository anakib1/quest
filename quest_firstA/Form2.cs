using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace quest_firstA
{
    public partial class Form2 : Form
    {
        int hp_b;
        int time;
        bool t = false;
        Stopwatch st = new Stopwatch();
        public Form2(string des, int hp,int time)
        {
            InitializeComponent();
            description2.Text = des;
            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = hp;
            hp_b = hp;
            progressBar1.Value = 0;
            progressBar1.Step = 10;
            this.time = time;
            st.Start();
            
        }
        
        private void hit_b_Click(object sender, EventArgs e)
        {
            hp_b -= 10;
            progressBar1.PerformStep();
            if(hp_b==0)
            {
               // st.Stop();
               double te = st.Elapsed.TotalMilliseconds;
                if(te>time*1000)
                {
                    MessageBox.Show("YOU LOST(", "battle");
                    t = true;
                    RES(false);
                }
                if (!t)
                {
                    MessageBox.Show("YOU WON!", "battle");
                    RES(true);
                }
                this.Close();
            }
        }
        void RES(bool win)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\bidzi\source\repos\quest_firstA\quest_firstA\res_of_b.txt"))
            {
                sw.WriteLine(win.ToString());
            }
        }
    }
}
