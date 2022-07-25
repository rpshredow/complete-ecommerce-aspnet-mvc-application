using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<NewMovieVM>
    {
        Task<NewMovieVM> GetMovieByIdAsync(int id);
    }
}
