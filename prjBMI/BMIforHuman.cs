using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI
{
    public class BMIforHuman:cBMI
    {
        public BMIforHuman()
        {
            Console.WriteLine($"物種名:人類\n");
        }
        public override string fn_getBMIresult()/*依照提供參數(high weight gender)來呼叫fn_getresult*/
        {
            if (bool_input_BMI_HighandWeight() && bool_input_BMI_speciesgender())
            {
                return genderActionMap[gender];
            }
            else
                return "輸入錯誤";
        }
    }
}
