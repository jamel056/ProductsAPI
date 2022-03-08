using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsAPI.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
