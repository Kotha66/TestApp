using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestAppLib
{
    public class Temperature
    {
        public Dictionary<string,string> calculateTemperature(List<string> tempartures)
        {


            int configSec = int.Parse(ConfigurationManager.AppSettings["TempConfig"]);
            int Milliseconds = 0;
            double Tempurature = 0;
            string[] Itemdata,tpr;
            
            Dictionary<int, string> tempSeconds = new Dictionary<int, string>();
            Dictionary<string, string> tempValues = new Dictionary<string, string>();
            //Reading Input sensors data
            foreach (var item in tempartures)
            {
                Itemdata = item.Split(',');
                
                Milliseconds = int.Parse(Itemdata[1]);
                Tempurature = double.Parse(Itemdata[2]);

                int key = (int)Math.Truncate(Milliseconds * (0.001 * configSec));
                if (tempSeconds.ContainsKey(key))
                    tempSeconds[key] = tempSeconds[key]+"#" + Tempurature.ToString();
                else
                    tempSeconds.Add(key, Tempurature.ToString());
            }
            string keyrange = string.Empty;
            //Calculating avrage
            foreach (KeyValuePair<int,string> item in tempSeconds)
            {
                Tempurature = 0;
                tpr = item.Value.Split('#');
                for(int i=0;i<tpr.Length;i++)
                {
                    Tempurature += double.Parse(tpr[i]);
                }
                keyrange = (item.Key * 1000).ToString()+"-"+ (((item.Key + 1) * 1000) - 1).ToString();     
                tempValues.Add(keyrange, (Tempurature / tpr.Length).ToString("#.##"));
            }


            return tempValues;

        }
       
    }
}
