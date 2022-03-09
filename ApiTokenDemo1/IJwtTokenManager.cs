namespace ApiTokenDemo1
{
    public interface IJwtTokenManager
    {
        string Authenticate(string userName, string password);
    }
}
