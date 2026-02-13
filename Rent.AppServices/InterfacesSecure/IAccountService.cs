using Rent.DomainLogic.AppResponses;
using Rent.DomainLogic.ModelUtility;

namespace Rent.AppService.InterfacesSecure;

public interface IAccountService
{
    Task<ActionResponse<TokenDTO>> LoginAsync(LoginDTO modelo);

    Task<ActionResponse<bool>> RecoverPasswordAsync(RecoveryPassDTO modelo, string frontUrl);

    Task<ActionResponse<bool>> ResetPasswordAsync(ResetPasswordDTO modelo);

    Task<ActionResponse<bool>> ChangePasswordAsync(ChangePasswordDTO modelo, string UserName);

    Task<ActionResponse<bool>> ConfirmEmailAsync(string userId, string token);
}