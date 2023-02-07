using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity // Maestro de productos
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        
        [StringLength(600)]
        public string ProductDescription { get; set; }
        
        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; }          // Relacion Ma1 con CategoryEntity, clave foranea - cada producto puede pertenecer solo a una categoría
        public CategoryEntity Category { get; set; }    // Relacion Ma1 con CategoryEntity - cada producto puede pertenecer solo a una categoría

        public ICollection<StorageEntity> Storages  { get; set; } // Relacion 1aM con almacenamiento, entidad StorageEntity - 1 Producto puede estar en varios almacenes
    }
}
