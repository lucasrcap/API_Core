namespace UserMasterAPI
{
    public interface IRefreshTokenGenerator
    {
        string GenerateToken(string username);
    }
}
