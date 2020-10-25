using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeController
{
    public static class Utils
    {
        public static DesignTypes ParseEnum(string name)
        {
           return (DesignTypes)Enum.Parse(typeof(DesignTypes), name);
        }


    }
}
