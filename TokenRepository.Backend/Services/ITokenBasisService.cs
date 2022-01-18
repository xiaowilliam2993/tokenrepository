using System.Collections.Generic;
using TokenRepository.Backend.Data.Models;

namespace TokenRepository.Backend.Services
{
    public interface ITokenBasisService
    {
        IEnumerable<dynamic> ToCollection(IEnumerable<TokenBasis> tokenBases, bool isNeedDecrpty = false);
        dynamic ToSingle(IEnumerable<TokenBasis> tokenBases);
    }
}
