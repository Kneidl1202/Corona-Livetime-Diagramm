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
        private bool clicked = false;
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Corona deaths and cases");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void loadDiagramm_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                Webinformation wf = new Webinformation();
                string[] wfArr = wf.WebInformation();
                Diagramm dg = new Diagramm();
                string[] xValues = dg.setDiagramm(wfArr).yValues;
                string[] yValues = dg.setDiagramm(wfArr).xValues;

                int j = 0;
                for (int i = 0; i < xValues.Length * 2; i += 2)
                {
                    chart1.Series["Death"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i]));
                    chart1.Series["Cases"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i + 1]));
                    chart2.Series["Deaths"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i]));
                    chart3.Series["Cases"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i + 1]));
                    j++;
                }
                clicked = true;
            }
            else
            {
                chart1.Series["Death"].Points.Clear();
                chart1.Series["Cases"].Points.Clear();
                chart2.Series["Deaths"].Points.Clear();
                chart3.Series["Cases"].Points.Clear();

                Webinformation wf = new Webinformation();
                string[] wfArr = wf.WebInformation();
                Diagramm dg = new Diagramm();
                string[] xValues = dg.setDiagramm(wfArr).yValues;
                string[] yValues = dg.setDiagramm(wfArr).xValues;

                int j = 0;
                for (int i = 0; i < xValues.Length * 2; i += 2)
                {
                    chart1.Series["Death"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i]));
                    chart1.Series["Cases"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i + 1]));
                    chart2.Series["Deaths"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i]));
                    chart3.Series["Cases"].Points.AddXY(xValues[j], Convert.ToInt32(yValues[i + 1]));
                    j++;
                }
            }
        }
    }
}

