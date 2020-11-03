namespace QuanLyTiemBanh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string PassWord { get; set; }

        public int? Type { get; set; }
    }
}
