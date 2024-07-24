using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadingDate.Configuration
{
    internal static class AppConfiguration
    {
        public static string DateInPath = Path.Combine(
            Directory.GetCurrentDirectory(), "DateIn.xml");
    }
}
