using System;
using System.Linq;
using System.Collections.Generic;
using TokenRepository.Client.Models.Base;
using TokenRepository.Client.Utility;

namespace TokenRepository.Client.Models
{
    public class TokenBasis : DocumentBase
    {
        private string _token = string.Empty;
        public string ID { get; set; }
        public string Token 
        {
            get => _token;
            set 
            {
                _token = value;
                SetTokenSecurityDisplayValue();
            } 
        }
        public string TokenSecurityDisplayValue { get; set; }
        public string SecurityKey { get; set; }
        public string[] SecurityLevels { get; set; }
        public bool? IsEnabledOfDateTurnOn { get; set; }
        public string EnabledDateControlStrategyDisplayValue
        {
            get
            {
                return IsEnabledOfDateTurnOn.HasValue && IsEnabledOfDateTurnOn.Value ? "Y" : "N";
            }
        }
        public DateTime? EnabledDate { get; set; }
        public string EnabledDateDisplayValue
        {
            get
            {
                return EnabledDate == null ? EnabledDate.Value.ToStringEx() : Formatter._SysDefaultDate;
            }
        }
        public string Prompt { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public void SetTokenSecurityDisplayValue()
        {
            if (!string.IsNullOrEmpty(TokenSecurityDisplayValue) && TokenSecurityDisplayValue.All(_ => _.Equals('#')))
            {
                TokenSecurityDisplayValue = _token;
            }
            else
            {
                if (!string.IsNullOrEmpty(_token))
                {
                    var chars = new char[_token.Length];
                    for (int i = 0; i < chars.Length; i++)
                    {
                        chars[i] = '#';
                    }
                    TokenSecurityDisplayValue = string.Join("", chars);
                }
            }
        }
    }
}
