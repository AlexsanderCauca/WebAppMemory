using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entitties
{
    [Table("Admins")]
    public class AppAdmins
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        [MaxLength(100)]
        public string Login { get; set; }
        [Column("password")]
        [MaxLength(100)]
        public string Password { get; set; }
    }
}