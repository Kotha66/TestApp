using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppLib
{
    public class Testcls
    {
        public string Student_Sitting(int number)
        {

            string Output = string.Empty;
            int counter = 0,flag=0;
            int rowChairs = number / 2;
            int totalRows = 2;

            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < rowChairs; j++)
                {
                    switch (counter)
                    {
                        case 0:
                            Output += "M ";
                            break;
                        case 1:
                            Output += "P ";
                            break;
                        case 2:
                            Output += "C ";
                            break;
                    }
                    counter++;
                    if (counter > 2)
                        counter = 0;
                    if (j == (rowChairs - 1) && number % 2 != 0 && flag == 0)
                    {
                        j--;
                        flag = 1;
                    }

                }
                if (number % 3 == 0)
                    counter++;

                Output += "\r";
            }

            return Output;
        }
    }
}
