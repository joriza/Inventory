using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity // Maestro de Categorías
    {
        [Key]
        [StringLength(50)]  // Son DataAnnotations lo que está entre []
        public string CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<ProductEntity> Products { get; set; }   // Relacion 1aM con Productos, entidad ProductEntity - 1 Categoria puede tener varios productos
    }
}
