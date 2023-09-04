using CRUDApi.DataContext;
using CRUDApi.Model;
using CRUDApi.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRUDApi.Services
{
    public interface IIdentityService
    {
        Task<Response<TokenModel>> LoginAsync(LoginModel login);
    }

    public class IdentityService : IIdentityService
    {
        private readonly DemoTokenContext _context;
        private readonly ServiceConfiguration _appSettings;

        private readonly TokenValidationParameters _tokenValidationParameters;
        public IdentityService(DemoTokenContext context,
            IOptions<ServiceConfiguration> settings,
            TokenValidationParameters tokenValidationParameters)
        {
            _context = context;
            _appSettings = settings.Value;
            _tokenValidationParameters = tokenValidationParameters;
        }


        //public async Task<Response<TokenModel>> LoginAsync(LoginModel login)
        //{
        //    Response<TokenModel> response = new Response<TokenModel>();
        //    try
        //    {
        //        string md5Password = MD5Helpers.GenerateMd5Hash(login.Password);
        //        UsersMaster loginUser = _context.UsersMaster.FirstOrDefault(c => c.UserName == login.UserName && c.Password == md5Password);

        //        if (loginUser == null)
        //        {
        //            response.IsSuccess = false;
        //            response.Message = "Invalid Username And Password";
        //            return response;
        //        }

        //        AuthenticationResult authenticationResult = await AuthenticateAsync(loginUser);
        //        if (authenticationResult != null && authenticationResult.Success)
        //        {
        //            response.Data = new TokenModel() { Token = authenticationResult.Token, RefreshToken = authenticationResult.RefreshToken };
        //        }
        //        else
        //        {
        //            response.Message = "Something went wrong!";
        //            response.IsSuccess = false;
        //        }

        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

       

        //public async Task<AuthenticationResult> AuthenticateAsync(UsersMaster user)
        //{
        //    return await AuthenticateAsync(user, null);

        //    // authentication successful so generate jwt token  
        //    AuthenticationResult authenticationResult = new AuthenticationResult();
        //    var tokenHandler = new JwtSecurityTokenHandler();

        //    try
        //    {
        //        var key = Encoding.ASCII.GetBytes(_appSettings.JwtSettings.Secret);

        //        ClaimsIdentity Subject = new ClaimsIdentity(new Claim[]
        //            {
        //            new Claim("UserId", user.UserId.ToString()),
        //            new Claim("FirstName", user.FirstName),
        //            new Claim("LastName",user.LastName),
        //            new Claim("EmailId",user.Email==null?"":user.Email),
        //            new Claim("UserName",user.UserName==null?"":user.UserName),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            });
        //        foreach (var item in GetUserRole(user.UserId))
        //        {
        //            Subject.AddClaim(new Claim(ClaimTypes.Role, item.RoleName));
        //        }

        //        var tokenDescriptor = new SecurityTokenDescriptor
        //        {
        //            Subject = Subject,
        //            Expires = DateTime.UtcNow.Add(_appSettings.JwtSettings.TokenLifetime),
        //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //        };
        //        var token = tokenHandler.CreateToken(tokenDescriptor);
        //        authenticationResult.Token = tokenHandler.WriteToken(token);
        //        var refreshToken = new RefreshToken
        //        {
        //            Token = Guid.NewGuid().ToString(),
        //            JwtId = token.Id,
        //            UserId = user.UserId,
        //            CreationDate = DateTime.UtcNow,
        //            ExpiryDate = DateTime.UtcNow.AddMonths(6)
        //        };
        //        await _context.RefreshToken.AddAsync(refreshToken);
        //        await _context.SaveChangesAsync();
        //        authenticationResult.RefreshToken = refreshToken.Token;
        //        authenticationResult.Success = true;
        //        return authenticationResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}

        Task<Response<TokenModel>> IIdentityService.LoginAsync(LoginModel login)
        {
            throw new NotImplementedException();
        }
    }
}  