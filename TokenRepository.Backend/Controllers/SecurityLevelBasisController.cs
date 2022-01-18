using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TokenRepository.Backend.Data;

namespace TokenRepository.Backend.Controllers
{
    [ApiController]
    [Route("api/v1/securityLevelBasis")]
    public class SecurityLevelBasisController : ControllerBase
    {
        private readonly ILogger<SecurityLevelBasisController> _logger;
        private readonly TokenDbContext _dbContext;

        public SecurityLevelBasisController(ILogger<SecurityLevelBasisController> logger, TokenDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public ApiContext Get()
        {
            try
            {
                var data = _dbContext.SecurityLevelBasis
                    .Select(_ => new
                    {
                        _.SecurityKey,
                        _.SecurityLevel,
                        _.SecurityLength,
                        _.CharacterElement,
                        _.IsValid,
                        _.Remark,
                        CreateDate = _.CreateDate.Value.ToString(),
                        ModifyDate = _.ModifyDate.Value.ToString()
                    })
                    .OrderBy(_ => _.SecurityLevel)
                    .ThenBy(_ => _.SecurityKey);

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = data
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Get SecurityLevelBasis has an occurs error: {ex.Message}");
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpGet("getLevel")]
        public ApiContext GetSecurityLevel()
        {
            try
            {
                var data = _dbContext.SecurityLevelBasis
                    .Select(_ => _.SecurityLevel)
                    .Distinct()
                    .OrderBy(_ => _);

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = data
                };
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Get security level has an occurs error: {ex.Message}");
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }

        [HttpGet("{securityLevel}")]
        public ApiContext GetSecurityKey(int securityLevel)
        {
            try
            {
                var data = _dbContext.SecurityLevelBasis
                    .Where(_ => _.SecurityLevel == securityLevel)
                    .Select(_ => _.SecurityKey)
                    .OrderBy(_ => _);

                return new ApiContext
                {
                    Status = ReturnStatus.Success,
                    Data = data
                };
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Get SecurityKey has an occurs error: {ex.Message}");
                return new ApiContext
                {
                    Status = ReturnStatus.Error,
                    Message = ex.Message
                };
            }
        }
    }
}
