using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TokenRepository.Backend.Data.Models
{
    [Table("TB_TokenBasis")]
    public class TokenBasis
    {
        [Key]
        public string ID { get; set; }
        public string Token { get; set; }
        public string SecurityKey { get; set; }
        public bool? IsEnabledOfDateTurnOn { get; set; }
        public DateTime? EnabledDate { get; set; }
        public string Prompt { get; set; }
        public bool? IsValid { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
