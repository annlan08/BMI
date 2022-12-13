using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI
{
    public class BMIforCat:cBMI
    {
        public BMIforCat()
        {
            Console.WriteLine($"物種名:喵咪\n");
        }
        protected override Dictionary<char, string> genderMap
        {
            get
            {
                Dictionary<char, string> _genderMap = new Dictionary<char, string>();
                _genderMap.Add('M', "男性");
                _genderMap.Add('W', "女性");
                _genderMap.Add('X', "不明");
                return _genderMap;
            }
        }
        protected override Dictionary<char, string> genderActionMap
        {
            get
            {
                Dictionary<char, string> _genderActionMap = new Dictionary<char, string>();
                _genderActionMap.Add('M', fn_printresult(30, 10, BMIvalue));
                _genderActionMap.Add('W', fn_printresult(20, 15, BMIvalue));
                _genderActionMap.Add('X', fn_printresult(100, 5, BMIvalue));
                return _genderActionMap;
            }
        }
        public override string fn_getBMIresult()
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
