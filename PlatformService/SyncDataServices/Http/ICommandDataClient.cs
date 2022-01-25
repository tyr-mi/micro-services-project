using platformservice.Dtos;
using System.Threading.Tasks;

namespace platformservice.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platform);
    }
}
