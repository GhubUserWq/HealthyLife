namespace hmrwk_TryCatch;

public class Logger
{
    public static void LogError(string code, string message)
    {
        DateTime time = DateTime.Now;

        Console.Write($"[{time.ToString("hh:mm:ss")} ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("ERR");
        Console.ResetColor();
        Console.Write("]");
        Console.Write($"{code}: {message}\n");

    }
}
