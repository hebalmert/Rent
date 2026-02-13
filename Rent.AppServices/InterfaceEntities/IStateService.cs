using Rent.Domain.Entities;
using Rent.DomainLogic.AppResponses;
using Rent.DomainLogic.ModelUtility;
using Rent.DomainLogic.Pagination;

namespace Rent.AppService.InterfaceEntities;

public interface IStateService
{
    Task<ActionResponse<IEnumerable<State>>> ComboAsync(ClaimsDTOs claimsDTO);

    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<State>> UpdateAsync(State modelo);

    Task<ActionResponse<State>> AddAsync(State modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}