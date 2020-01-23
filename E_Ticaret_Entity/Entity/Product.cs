using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Entity.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Emlak Adı")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int SquareMeter { get; set; }
        public string RoomQuantity { get; set; }
        public string heat { get; set; }
        public string Image { get; set; }
        public bool IsSell { get; set; } //Satılık mı? Kiralık mı?

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
