using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI
{
    public class BMIforDOG:cBMI
    {
        public BMIforDOG()
        {
            Console.WriteLine($"物種名:狗狗\n");
        }

        public override string fn_getBMIresult()/*身高體重性別 狗的*/
        {
            if(bool_input_BMI_HighandWeight())
            {
                return fn_printresult(30, 10, BMIvalue);
            }
            else
            {
                return "資料錯誤";
            }
        }
    }
}
