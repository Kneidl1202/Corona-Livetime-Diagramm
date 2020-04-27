using System;
using System.Net;

namespace Corona_LiveTime_Diagramm
{
    class Webinformation
    {
        #region WebInformation

        // returns a string[,]: first = casesdate, second = casesinfo,  third = infodeath;

        public string[] WebInformation()
        {
            //Define Variable Client which is a WebClient
            var client = new WebClient();
            //The Client Downloads the HTML as a String
            string htmltext = client.DownloadString("https://www.worldometers.info/coronavirus/");

            // CASES
            string casesdate = Cases(htmltext).date;
            string casesinfo = Cases(htmltext).info;
            // DEATH
            string datedeath = Death(htmltext).date;
            string infodeath = Death(htmltext).info;

            // string []
            string[] output = { casesdate, casesinfo, infodeath };
            //returns output
            return output;
        }
        #endregion

        #region Cases with date
        private (string date, string info) Cases(string input)
        {
            //Date is on line 764
            //Data is on line 790

            //splits the input into lines
            string[] lines = input.Split('\n');

            //The Dateline is the exact line... also the info line
            string dateline = lines[764];
            string Infoline = lines[790];

            //removes the parts
            return (RemoveBracket(dateline), RemoveBracket(Infoline));

        }
        #endregion
        #region Death with date

        private (string date, string info) Death(string input)
        {
            //Date is on line 930
            //Data is on line 954

            //splits the input into lines
            string[] lines = input.Split('\n');

            //The Dateline is the exact line... also the info line
            string dateline = lines[930];
            string Infoline = lines[954];

            //removes the parts
            return (RemoveBracket(dateline), RemoveBracket(Infoline));
        }
        #endregion
        #region removeBracket
        private string RemoveBracket(string input)
        {
            //This method removes the part before the [ and after the ] with the bracket
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[')
                {
                    input = input.Remove(0, i + 1);
                    break;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ']')
                {
                    input = input.Remove(i);
                    break;
                }
            }
            return input;
        }
        #endregion
    }
}
