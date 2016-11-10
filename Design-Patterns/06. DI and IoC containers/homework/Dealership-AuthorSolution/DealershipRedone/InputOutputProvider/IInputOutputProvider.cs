namespace DealershipRedone.InputOutputProvider
{
    public interface IInputOutputProvider
    {
        string ReadInput();

        void WriteOutput(string value);
    }
}
