using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegata.Delegate
{
    public class StringFunction
    {
        public static int GEtUapperCharsCount(string name)
        {
            int counter = 0;
            if (string.IsNullOrEmpty(name))
                for (int i = 0;i < name.Length;i++)
                    if (char.IsUpper(name[i]))
                        counter++;
            

            
            return counter;
        }
    }
}
