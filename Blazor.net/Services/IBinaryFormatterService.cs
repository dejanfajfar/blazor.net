using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.net.Services
{
    public interface IBinaryFormatterService
    {
        string ToBinary(int number, int minLength = 0);
    }
}
