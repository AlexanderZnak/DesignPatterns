namespace Builder
{
    public class ConsoleWrite : IConsoleWrite
    {

        private static ConsoleWrite Write = new();
        public static ConsoleWrite Instance => Write;
        public string Deploy()
        {
            return "Application is deployed";
        }
    }
}