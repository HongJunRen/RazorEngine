using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorEngine
{
    internal class Utils
    {
        public static bool IsMono;
        static Utils () 
        {
            try 
            {
                IsMono = Type.GetType("Mono.Runtime") != null;
            }
            catch (Exception)
            {
                IsMono = false;
            }
        }
    }
}
