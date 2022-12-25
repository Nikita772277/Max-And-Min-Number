using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_And_Min_Number
{
    internal class Checks
    {
        public string SearchForExtremeValues(string number)
        {
            if (string.IsNullOrEmpty(number))
                return "Строка пуста";
            var split= number.Split(' ',',');
            bool checkFirstPosition = int.TryParse(split[0], out int resultFirstPosition);
            int maxNumber = resultFirstPosition, minNumber = resultFirstPosition;
            for(int i = 0; i < split.Length; i++)
            {
                bool check = int.TryParse(split[i], out int result);
                if (maxNumber < result)
                    maxNumber = result;
                if (minNumber > result)
                    minNumber = result;
            }
            return $"Максимальное число: {maxNumber}\nМинимальное число: {minNumber}";
        }
    }
}
