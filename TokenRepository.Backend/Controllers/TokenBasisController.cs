using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TokenRepository.Backend.Data;
using TokenRepository.Backend.Data.Models;
using TokenRepository.Backend.Services;
using TokenRepository.Backend.Utility;

namespace TokenRepository.Backend.Controllers
{
    [ApiController]
    [Route("api/v1/tokenBasis")]
    public class TokenBasisController : ControllerBase
    {
        private readonly ILogger<TokenBasisController> _logger;
        private readonly TokenDbContext _dbContext;
        private readonly ITokenBasisService _tokenBasisService;

        public TokenBasisController(ILogger<TokenBasisController> logger, TokenDbContext dbContext, ITokenBasisService tokenBasisService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _tokenBasisService = tokenBasisService;
        }

        [HttpGet("getall")]
        public ApiContext GetAll()
        {
            try
            {
                _logger.LogWarning("Get all the TokenBasis.");

                var data = _dbContext.TokenBasis;

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = _tokenBasisService.ToCollection(data)
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Get TokenBasis has an occurs error: {ex.Message}");

                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpGet("{pTokenSearchVal}")]
        public ApiContext Get(string pTokenSearchVal)
        {
            return Get(pTokenSearchVal, bool.FalseString);
        }

        [HttpGet("{pTokenSearchVal}/{isNeedDecrypt}")]
        public ApiContext Get(string pTokenSearchVal, string isNeedDecrypt)
        {
            try
            {
                var data = string.IsNullOrEmpty(pTokenSearchVal) ? Enumerable.Empty<TokenBasis>() :
                    _dbContext.TokenBasis.Where(_ => _.ID.Contains(pTokenSearchVal, StringComparison.CurrentCultureIgnoreCase));

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = _tokenBasisService.ToCollection(data, ConvertUtil.ToBoolean(isNeedDecrypt))
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Get TokenBasis has an occurs error: {ex.Message}");

                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpPost]
        public async Task<ApiContext> Post(TokenBasis tokenBasis)
        {
            #region Parameter validate
            if (tokenBasis == null) throw new ArgumentNullException(nameof(tokenBasis));
#pragma warning disable CA2208 // 正确实例化参数异常
            if (string.IsNullOrEmpty(tokenBasis.ID)) throw new ArgumentNullException(nameof(tokenBasis.ID));
#pragma warning restore CA2208 // 正确实例化参数异常
            #endregion

            try
            {
                var existenceItem = _dbContext.TokenBasis.Find(tokenBasis.ID);
                if (existenceItem != null)
                {
                    throw new Exception($"TokenBasis by ID '{tokenBasis.ID}' does exists.");
                }
                tokenBasis.CreateDate = DateTime.Now;

                _dbContext.TokenBasis.Add(tokenBasis);
                await _dbContext.SaveChangesAsync();

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = existenceItem
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Post TokenBasis occurs an error.", ex);
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpPut]
        public async Task<ApiContext> Put(TokenBasis tokenBasis)
        {
            #region Parameter validate
            if (tokenBasis == null) throw new ArgumentNullException(nameof(tokenBasis));
#pragma warning disable CA2208 // 正确实例化参数异常
            if (string.IsNullOrEmpty(tokenBasis.ID)) throw new ArgumentNullException(nameof(tokenBasis.ID));
#pragma warning restore CA2208 // 正确实例化参数异常
            #endregion

            try
            {
                var existenceToken = _dbContext.TokenBasis.Find(tokenBasis.ID);
                if (existenceToken != null)
                {
                    existenceToken.Token = tokenBasis.Token;
                    existenceToken.SecurityKey = tokenBasis.SecurityKey;
                    existenceToken.IsEnabledOfDateTurnOn = tokenBasis.IsEnabledOfDateTurnOn;
                    existenceToken.EnabledDate = tokenBasis.EnabledDate;
                    existenceToken.Prompt = tokenBasis.Prompt;
                    existenceToken.Remark = tokenBasis.Remark;
                    existenceToken.ModifyDate = DateTime.Now;
                    _dbContext.Entry(existenceToken).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception($"TokenBasis by ID '{tokenBasis.ID}' does not exists.");
                }
                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = existenceToken
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Put TokenBasis occurs an error.", ex);
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpDelete("{id}")]
        public async Task<ApiContext> Delete(string id)
        {
            #region Parameter validate
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            #endregion

            try
            {
                var existenceToken = _dbContext.TokenBasis.Find(id);
                if (existenceToken != null)
                {
                    _dbContext.Entry(existenceToken).State = EntityState.Deleted;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception($"TokenBasis by ID '{id}' does not exists.");
                }

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Message = "Delete TokenBasis successfully."
                };
            }
            catch(Exception ex)
            {
                _logger.LogError("Delete TokenBasis occurs an error.", ex);
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpGet("getNewToken/{securityKey}")]
        public async Task<ApiContext> GetNewToken(string securityKey)
        {
            #region Parameters validate
            if (string.IsNullOrEmpty(securityKey)) throw new ArgumentNullException(nameof(securityKey));
            #endregion

            try
            {
                var securityEntry = await _dbContext.SecurityLevelBasis.FindAsync(securityKey);
                if (securityEntry == null)
                {
                    throw new Exception($"The security level basis of {securityKey} is not exists.");
                }
                if (!securityEntry.IsValid.HasValue || !securityEntry.IsValid.Value)
                {
                    throw new Exception($"The security level basis of {securityKey} is not effective.");
                }

                string characterElement = securityEntry.CharacterElement;
                char[] token = new char[securityEntry.SecurityLength];
                Random random = new();
                int randomMaxValue = characterElement.Length - 1;
                for (int i = 0; i < token.Length; i++)
                {
                    token[i] = characterElement[random.Next(0, randomMaxValue)];
                }

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = new string(token)
                };
            }
            catch(Exception ex)
            {
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }
    }
}
