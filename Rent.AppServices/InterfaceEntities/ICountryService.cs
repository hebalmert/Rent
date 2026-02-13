using Rent.Domain.Entities;
using Rent.DomainLogic.ModelUtility;
using Rent.DomainLogic.Pagination;

namespace Rent.AppService.InterfaceEntities;

public interface ICountryService
{
    Task<ActionResponse<IEnumerable<Country>>> ComboAsync();

    Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<Country>> UpdateAsync(Country modelo);

    Task<ActionResponse<Country>> AddAsync(Country modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}