using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PartialClass
{

    // Partial => Aynı isimde birden fazla class geliştirmemizi sağlayan yapılardır. Ayrı yazılır birlikte derlenirler. Derlenme aşamasında iki farklı class birleştirilerek kullanılabilir..


    public partial class Ogrenci // Aynı isme sahip class
    {
        public string Adi{ get; set; }
        public string Soyadı { get; set; }


    }
}
