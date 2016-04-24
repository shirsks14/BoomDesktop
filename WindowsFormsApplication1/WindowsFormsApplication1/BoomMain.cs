using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BoomMain
    {
        List<double> ffts;
        List<double> t;
        List<double> f;
        List<double> y;

        public BoomMain()
        {
            MLApp.MLApp matlab = new MLApp.MLApp();

            
            matlab.Execute(@"cd 'D:\Sujan\Skills\Coding\Hackathons\Nasa Space Apps - 2016\Data'");
            
            object result = null;
            // Call the MATLAB function myfunc
            matlab.Feval("fourier_transform", 4, out result);
            ffts = new List<double>();
            f = new List<double>();
            t = new List<double>();
            y = new List<double>();
            //Display result
            object[] res = result as object[];
            double[,] temp = (double[,])res[0];
            double[,] temp_1 = (double[,])res[1];
            double[,] temp_2 = (double[,])res[2];
            double[,] temp_3 = (double[,])res[3];

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                ffts.Add(temp[0, i]);
                f.Add(temp_3[0, i]);
            }

            for (int i = 0; i < temp_1.GetLength(0); i++)
            {
                y.Add(temp_1[0, i]);
                t.Add(temp_2[0, i]);

            }
            //for (int i = 0; res.GetLength(0))
            //    object temp = res[0];
            //double temp = Convert.ToDouble(res[0]);



        }

        public List<double> Ffts
        {
            get
            {
                return ffts;
            }
        }

        public List<double> T
        {
            get
            {
                return t;
            }
        }

        public List<double> F
        {
            get
            {
                return f;
            }
        }

        public List<double> Y
        {
            get
            {
                return y;
            }
        }
    }
}
