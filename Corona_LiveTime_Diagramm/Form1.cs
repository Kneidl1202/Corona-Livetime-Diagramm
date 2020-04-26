using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_LiveTime_Diagramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        public void setValuesDiagramm(string[] xValues, string[] yValues)
        {
            int j = 0;
            for (int i = 0; i < 1; i += 2)
            {
                chart1.Series["Death"].Points.AddXY("max", 22);
                chart1.Series["Cases"].Points.AddXY("dominik", 11);
                j++;
            }
        }

        private void loadDiagramm_Click(object sender, EventArgs e)
        {
            Combine();
        }

        public void Combine()
        {
            Webinformation wf = new Webinformation();
            string[] wfArr = wf.WebInformation();
            Diagramm dg = new Diagramm();
            dg.setDiagramm(wfArr);
        }
    }
}
