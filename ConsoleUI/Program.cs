using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace ConsoleUI
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintance: water pump turned on");
            log.Warn("Maintance: the water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {

                log.Error("Developer: we divide by zero", ex);
            }

            log.Fatal("Maintance: Water pump exploded!");

            Console.ReadLine();
        }
    }
}
