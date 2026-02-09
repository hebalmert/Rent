using Rent.DomainLogic.ModelUtility;

namespace Rent.AppBack.LoadCountries;

public interface IApiService
{
    Task<Response> GetListAsync<T>(string servicePrefix, string controller);
}