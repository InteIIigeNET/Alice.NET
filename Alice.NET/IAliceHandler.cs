using System.Threading.Tasks;

namespace Alice
{
    public interface IAliceHandler
    {
        Task<AliceResponse> Handle(AliceArgs args);
    }
}
