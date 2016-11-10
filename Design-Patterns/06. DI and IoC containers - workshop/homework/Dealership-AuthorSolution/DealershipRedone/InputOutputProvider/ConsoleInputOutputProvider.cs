using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipRedone.InputOutputProvider
{
    public class ConsoleInputOutputProvider : IInputOutputProvider
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void WriteOutput(string value)
        {
            Console.WriteLine(value);
        }
    }
}
