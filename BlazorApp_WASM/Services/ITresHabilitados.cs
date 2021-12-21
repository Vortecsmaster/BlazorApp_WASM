using System.Threading.Tasks;
using BlazorApp_WASM.Dtos;

namespace BlazorApp_WASM.Services
{
    public interface ITresHabilitados
    {
        Task<LaunchDto[]> GetAllTresHabilitados();
    }
}
