using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity // Entidad que pertenece al lugar físico donde está guardado cada producto (almacenes o bodegas)
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; } // Relacion 1aM con almacenamiento, entidad StorageEntity - 1 Almacen puede ...
    }
}
