using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flag = "GO";
            while (flag.ToUpper() == "GO")
            {
                string species = "";
                string result = "";
                Console.WriteLine("輸入物種 人類輸入HUMAN 狗輸入DOG 貓輸入CAT");
                species = Console.ReadLine().ToUpper();

                switch (species)
                {
                    case "HUMAN":
                        result = (new BMIforHuman()).fn_getBMIresult();
                        break;
                    case "DOG":
                        result = (new BMIforDOG()).fn_getBMIresult();
                        break;
                    case "CAT":
                        result = (new BMIforCat()).fn_getBMIresult();
                        break;
                    default:
                        result = "無此選項";
                        break;
                }
                Console.WriteLine(result);
                Console.WriteLine("輸入go已繼續，或任意值已停止");
                flag = Console.ReadLine().ToUpper();
            }
        }


    }
}
