using System.Threading;
using System.Threading.Tasks;

namespace Meziantou.OneDrive
{
    public class MemoryRefreshTokenHandler : IRefreshTokenHandler
    {
        private RefreshTokenInfo _token;

        public Task SaveRefreshTokenAsync(RefreshTokenInfo token, CancellationToken ct)
        {
            _token = token;
            return Task.FromResult(0);
        }

        public Task<RefreshTokenInfo> RetrieveRefreshTokenAsync(CancellationToken ct)
        {
            return Task.FromResult(_token);
        }

        public Task DeleteRefreshTokenAsync(CancellationToken ct)
        {
            _token = null;
            return Task.FromResult(0);
        }
    }
}