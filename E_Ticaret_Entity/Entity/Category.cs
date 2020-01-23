using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Entity.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Emlak Adı")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public double Price { get; set; }

        [DisplayName("Genişlik")]
        public int SquareMeter { get; set; }

        [DisplayName("Oda Sayısı")]
        public string RoomQuantity { get; set; }

        [DisplayName("Sıcaklık")]
        public string heat { get; set; }


        public List<Product> Products { get; set; }
    }
}
