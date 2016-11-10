namespace DealershipRedone.InputOutputProvider
{
    public interface IInputOutputProvider
    {
        string ReadLineInput();

        int ReadInput();

        void WriteLineOutput(string value);

        void WriteOutput(string value);
    }
}
