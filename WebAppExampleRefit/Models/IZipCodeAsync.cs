using Refit;
using System.Threading.Tasks;

namespace WebAppExampleRefit.Models
{
    public interface IZipCodeAsync
    {
        [Get("/ws/{value}/json")]
        Task<ZipCode> GetZipAsync(string value);
    }
}
