using System.Collections.Generic;
using System.Linq;
using TokenRepository.Backend.Data.Models;
using TokenRepository.Backend.Utility;

namespace TokenRepository.Backend.Services.Implement
{
    public class TokenBasisServiceImpl : ITokenBasisService
    {
        public IEnumerable<dynamic> ToCollection(IEnumerable<TokenBasis> tokenBases, bool isNeedDecrpty = false)
        {
            return tokenBases.Select(_ => new {
                _.ID,
                Token = isNeedDecrpty ? Encoder.ToDeconding(_.Token) : _.Token,
                _.SecurityKey,
                IsEnabledOfDateTurnOn = _.IsEnabledOfDateTurnOn.Value,
                EnabledDate = _.EnabledDate.Value.ToStringEx(),
                _.IsValid,
                _.Prompt,
                _.Remark,
                CreateDate = _.CreateDate.Value.ToStringEx(),
                ModifyDate = _.ModifyDate.Value.ToStringEx()
            });
        }

        public dynamic ToSingle(IEnumerable<TokenBasis> tokenBases)
        {
            return ToCollection(tokenBases)?.FirstOrDefault();
        }
    }
}
