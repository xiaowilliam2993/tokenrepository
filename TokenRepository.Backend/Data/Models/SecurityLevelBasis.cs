using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TokenRepository.Backend.Data.Models
{
    [Table("TB_SecurityLevelBasis")]
    public class SecurityLevelBasis
    {
        [Key]
        public string SecurityKey { get; set; }
        public int SecurityLevel { get; set; }
        public int SecurityLength { get; set; }
        public string CharacterElement { get; set; }
        public string Remark { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
