using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI
{
    abstract public class cBMI
    {
        public double high { get; set; } /*身高cm*/
        public double weight { get; set; }/*體重kg*/
        public char gender { get; set; }/*使用者輸入的性別*/
        
        protected virtual double BMIvalue {
            get
            {
                double meter = high / 100;
                double result = weight / (meter * meter);
                return result;
            }
        }/*計算出來的BMI*/
        protected virtual Dictionary<char, string> genderMap {
            get
            {
                Dictionary<char, string>  _genderMap = new Dictionary<char, string>();
                _genderMap.Add('M', "男性");
                _genderMap.Add('W', "女性");
                return _genderMap;
            }
        }/*性別及對應全名總表*/
        protected virtual Dictionary<char, string> genderActionMap
        {
            get { 
                Dictionary<char, string> _genderActionMap = new Dictionary<char, string>();
                _genderActionMap.Add('M', fn_printresult(25, 20, BMIvalue));
                _genderActionMap.Add('W', fn_printresult(22, 18, BMIvalue));
                return _genderActionMap;
            }
        }

        public abstract string fn_getBMIresult();/*依照提供參數(high weight gender)來呼叫fn_getresult*/

        protected string fn_printresult(int max, int min, double result)/*透過性別區間計算顯示結果*/
        {
            if (result > max)
                return "太胖";
            else if (result < min)
                return "太瘦";
            else
                return "適中";
        }
        protected bool bool_input_BMI_HighandWeight()/*使用者輸入身高體重*/
        {
            try
            {
                Console.WriteLine("輸入體重(kg)");
                weight = double.Parse(Console.ReadLine());

                Console.WriteLine("輸入身高(cm)");
                high = double.Parse(Console.ReadLine());

                return true;
            }
            catch
            {
                Console.WriteLine("請輸入實際數值");
                return bool_input_BMI_HighandWeight();
            }
        }
        protected bool bool_input_BMI_speciesgender()/*使用者輸入物種性別代碼*/
        {
            try
            {
                string gender_string = "";
                foreach (KeyValuePair<char, string> item in genderMap)
                {
                    gender_string += $"{item.Key.ToString()}代表{item.Value} ";
                }

                Console.WriteLine($"輸入性別({gender_string})");
                gender = Convert.ToChar(Console.ReadLine().ToUpper());

                if (genderMap.Keys.Contains(gender))
                    return true;
                else
                {
                    Console.WriteLine("錯誤性別");
                    return bool_input_BMI_speciesgender();
                }
            }
            catch
            {
                Console.WriteLine("字元輸入錯誤");
                return bool_input_BMI_speciesgender();
            }
        }
    }
}
