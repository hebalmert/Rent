using Rent.AppService.InterfaceEntities;
using Rent.AppServiceX.InterfaceEntities;
using Rent.Domain.Entities;
using Rent.DomainLogic.ModelUtility;
using Rent.DomainLogic.Pagination;

namespace Rent.UnitOfWork.ImplementEntities;

public class CountryServiceX : ICountryServiceX
{
    private readonly ICountryService _countriesService;

    public CountryServiceX(ICountryService countriesService)
    {
        _countriesService = countriesService;
    }

    public async Task<ActionResponse<IEnumerable<Country>>> ComboAsync() => await _countriesService.ComboAsync();

    public async Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination) => await _countriesService.GetAsync(pagination);

    public async Task<ActionResponse<Country>> GetAsync(int id) => await _countriesService.GetAsync(id);

    public async Task<ActionResponse<Country>> UpdateAsync(Country modelo) => await _countriesService.UpdateAsync(modelo);

    public async Task<ActionResponse<Country>> AddAsync(Country modelo) => await _countriesService.AddAsync(modelo);

    public async Task<ActionResponse<bool>> DeleteAsync(int id) => await _countriesService.DeleteAsync(id);
}