namespace hmrwk_TryCatch
{
    internal class InvalidUserCredentialsException : Exception
    {
        public const string Code = "invalid_user_credentials";
        public InvalidUserCredentialsException() : base("Username or password is incorrect")
        {
        }

    }
}
