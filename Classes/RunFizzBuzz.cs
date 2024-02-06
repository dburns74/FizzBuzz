using FizzBuzz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Classes
{
    internal class RunFizzBuzz
    {
        private List<INumberChecker> _numberCheckers = new List<INumberChecker>();
        public void Run()
        {
            GetNumberCheckers();
        }

        private void GetNumberCheckers()
        {
            var interfaceType = typeof(INumberChecker);

            //Search assemblies for classes implementing the interface
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(x => x.GetTypes())
                        .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass);

            foreach(var type in types)
            {
                var instance=Activator.CreateInstance(type);
                if(instance != null)
                {
                    _numberCheckers.Add((INumberChecker)instance);
                }
            }
        }
    }
}
