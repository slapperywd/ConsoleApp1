using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CollorCreator
    {
        public static T GetColorEnum<T>(T colorEnum)
            where T : struct
        {
            return (T)Enum.ToObject(typeof(T), Convert.ToInt32(colorEnum));
        }
    }
}
