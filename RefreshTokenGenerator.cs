using System.Security.Cryptography;
using UserMasterAPI.Models;

namespace UserMasterAPI
{
    public class RefreshTokenGenerator :  IRefreshTokenGenerator
    {
        private readonly Learn_DBContext context;

        public RefreshTokenGenerator(Learn_DBContext learn_DB)
        {
            context = learn_DB;
        }
        public string GenerateToken(string username)
        {
            var randomNumber = new byte[32];
            using (var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(randomNumber);
                string RefreshToken = Convert.ToBase64String(randomNumber);

                var _user = context.TblRefreshtoken.FirstOrDefault(o => o.UserId == username);
                if (_user != null)
                {
                    _user.RefreshToken = RefreshToken;
                    context.SaveChanges();
                } 
                else
                {
                    TblRefreshtoken tblRefreshtoken = new TblRefreshtoken()
                    {
                        UserId = username,
                        TokenId = new Random().Next().ToString(),
                        RefreshToken= RefreshToken,
                        IsActive = true
                    };
                }

                return RefreshToken;
            }
        }
    }
}
