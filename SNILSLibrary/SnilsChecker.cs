using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SNILSLibrary
{
    public class SnilsChecker
    {
        /// <summary>
        /// Расчет контрольной цифры СНИЛС
        /// </summary>
        /// <param name="textString">В качестве параметра передается строка из цифр</param>
        /// <returns>Метод возвращает true, если СНИЛС задан верно, false – в случае неверного СНИЛС</returns>
        public bool CheckPersonakCode(string textString)
        { 

            for (int i = 0; i < textString.Length; i++)
            {
                if (!Char.IsDigit(textString[i]))
                {
                    textString = textString.Replace(textString[i], ' ');
                }
            }
            textString = textString.Replace(" ", "");


            if (String.IsNullOrWhiteSpace(textString) || textString.Length != 11)
            {
                return false;
            }

            int number = textString.Length - 2;
            int multSNILS = 0;
            
            for (int i = 0; i <= textString.Length - 3; i++)
            {
                multSNILS += Convert.ToInt32(textString[i].ToString()) * number;
                number--;
            }

            if (multSNILS < 100)
            {
                if (multSNILS == Convert.ToInt32(textString[textString.Length - 2].ToString() + textString[textString.Length - 1].ToString()))
                {
                    return true;
                }
            }
            if (multSNILS == 100 || multSNILS == 101)
            {
                if(textString[textString.Length - 2].ToString() + textString[textString.Length - 1].ToString() == "00" )
                {
                    return true;
                }
            }

            if (multSNILS > 101)
            {
                double del = multSNILS % 101;

                if(del < 100)
                {
                    if (del == Convert.ToInt32(textString[textString.Length - 2].ToString() + textString[textString.Length - 1].ToString()))
                    {
                        return true;
                    }
                }
                if (del == 100 || del == 101)
                {
                    if (textString[textString.Length - 2].ToString() + textString[textString.Length - 1].ToString() == "00")
                    {
                        return true;
                    }
                }

            }

            return false;
        }
    }
}
