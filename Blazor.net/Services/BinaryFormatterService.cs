using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.net.Services
{
    public class BinaryFormatterService : IBinaryFormatterService
    {
        public string ToBinary(int number, int minLength = 0)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary;
        }
    }
}
