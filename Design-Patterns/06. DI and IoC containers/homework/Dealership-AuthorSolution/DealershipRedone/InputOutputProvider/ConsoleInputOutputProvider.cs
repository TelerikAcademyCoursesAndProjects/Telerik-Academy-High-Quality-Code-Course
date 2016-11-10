using System;

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
