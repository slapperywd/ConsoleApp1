using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InstanceContainer
    {
        private static Dictionary<Type, object> incstanceHolder= new Dictionary<Type, object>();

        public static void Register<T>(object source)
        {
            incstanceHolder.Add(typeof(T), source);
        }

        public static T Resolve<T>()
        {
            return (T) incstanceHolder[typeof(T)];
        }
    }
}
