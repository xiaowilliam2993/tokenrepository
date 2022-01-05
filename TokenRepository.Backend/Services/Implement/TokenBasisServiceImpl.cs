using System.Collections.Generic;
using System.Linq;
using TokenRepository.Backend.Data.Models;
using TokenRepository.Backend.Utility;

namespace TokenRepository.Backend.Services.Implement
{
    public class TokenBasisServiceImpl : ITokenBasisService
    {
        public IEnumerable<dynamic> ToCollection(IEnumerable<TokenBasis> tokenBases)
        {
            return tokenBases.Select(_ => new {
                _.ID,
                Token = Encoder.ToDeconding(_.Token),
                _.SecurityKey,
                IsEnabledOfDateTurnOn = _.IsEnabledOfDateTurnOn.Value,
                EnabledDate = _.EnabledDate.Value.ToString(),
                _.Prompt,
                _.Remark,
                CreateDate = _.CreateDate.Value.ToString(),
                ModifyDate = _.ModifyDate.Value.ToString()
            });
        }

        public dynamic ToSingle(IEnumerable<TokenBasis> tokenBases)
        {
            return ToCollection(tokenBases)?.FirstOrDefault();
        }
    }
}
