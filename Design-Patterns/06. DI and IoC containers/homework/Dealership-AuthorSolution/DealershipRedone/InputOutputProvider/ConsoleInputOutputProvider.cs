using System;

namespace DealershipRedone.InputOutputProvider
{
    public class ConsoleInputOutputProvider : IInputOutputProvider
    {
        public string ReadLineInput()
        {
            return Console.ReadLine();
        }
        public int ReadInput()
        {
            return Console.Read();
        }

        public void WriteLineOutput(string value)   
        {
            Console.WriteLine(value);
        }

        public void WriteOutput(string value)
        {
            Console.Write(value);
        }
    }
}
