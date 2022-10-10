using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.ilk
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } //Id adı verildiğinde otomatik olarak primary key olarak algılanıyor, bunun haricindeki kullanımlarda [Key] attribute u gerekir.
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
