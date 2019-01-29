using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Oluşturan Kullanıcı")]
        public string CreatedBy { get; set; }
        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Güncelleyen Kullanıcı")]
        public string UpdatedBy { get; set; }
    }
}
