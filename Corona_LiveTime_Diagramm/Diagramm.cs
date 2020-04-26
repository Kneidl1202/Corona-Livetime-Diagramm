using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_LiveTime_Diagramm
{
    class Diagramm
    {

        public void setDiagramm(string[] datas)
        {
            // datas is a string[,]: first = casesdate, second = casesinfo, third = infodeath;

            string[] dates = datas[0].Split(',');
            string[] cases = datas[1].Split(',');
            string[] deaths = datas[2].Split(',');

            int dateDifference = datas[0].Split(',').Length;
            string[] xValues = new string[dateDifference];
            string[] yValues = dates;

            int j = 0;
            for(int i = 0; i < cases.Length; i += 2)
            {
                xValues[i] = deaths[j].replace('"', '');
                xValues[i + 1] = cases[j].replace('"', '');
                j++;
            }

            Form1 f1 = new Form1();
            f1.setValuesDiagramm(xValues, yValues);
        } 
    }
}
