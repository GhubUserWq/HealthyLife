namespace hmrwk_TryCatch
{
    internal class Program
    {
        static string userName = "username";
        static string password = "passwd";
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile();

            Console.Write("Username: ");
            user.UserName = Console.ReadLine();
            Console.Write("Password: ");
            user.UserPassword = Console.ReadLine();

            try
            {
                Console.Clear();

                ValidateUser(user);

                Console.WriteLine("Welcome to the system...");
            }
            catch (InvalidUserCredentialsException ex)
            {
                Console.Clear();

                Logger.LogError(InvalidUserCredentialsException.Code, ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Session finished");
                Console.ResetColor();
            }
        }
        static void ValidateUser(UserProfile user)
        {
            if (user.UserName != userName || user.UserPassword != password)
                throw new InvalidUserCredentialsException();

        }
    }
}


