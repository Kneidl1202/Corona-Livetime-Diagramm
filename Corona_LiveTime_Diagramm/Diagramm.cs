using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_LiveTime_Diagramm
{
    class Diagramm
    {

        public (string[] xValues, string[] yValues) setDiagramm(string[] datas)
        {
            // datas is a string[,]: first = casesdate, second = casesinfo, third = infodeath;

            string[] dates = datas[0].Split(',');
            string[] cases = datas[1].Split(',');
            string[] deaths = datas[2].Split(',');

            int dateDifference = datas[0].Split(',').Length;
            string[] xValues = new string[dateDifference * 2];
            string[] yValues = new string[dates.Length];

            for (int i = 0; i < yValues.Length; i++)
            {
                string temp = dates[i].Replace("\\", "");
                yValues[i] = temp.Replace("\"", "");
            }

            int j = 0;
            for(int i = 0; i < cases.Length * 2; i += 2)
            {
                xValues[i] = deaths[j];
                xValues[i + 1] = cases[j];
                j++;
            }

            return (xValues, yValues);
        } 
    }
}
