using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.ilk
{
    public class Product : BaseEntity
    {

        //public Product(string name, int stock, decimal price, int categoryId, Category category, ProductFeature productFeature)
        //{
        //    Name = name ?? throw new ArgumentNullException(nameof(name)); //instance üretilirken null olursa nullexception hatası fırlatması için kullanım.
        //}

        public string? Name { get; set; } // ? null olabilir anlamı taşır.
        public int Stock { get; set; }
        public Decimal Price{ get; set; }
        public int CategoryId { get; set; } //#1 Category_Id olarak vb custom isim belirtirsem ...

        //#2 ... [forignKey("Category_Id")] Şeklinde vermem gerekir, mevcut kullanımda otomatik algılanıyor. 
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    
    }
}
