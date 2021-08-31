using Refit;
using System.Threading.Tasks;

namespace WebAppExampleRefit.Models
{
    public interface IZipCode
    {
        [Get("/ws/{value}/json")]
        Task<ZipCode> GetAsync(string value);
    }
}
