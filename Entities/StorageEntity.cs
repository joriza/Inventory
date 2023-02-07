using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity // Entidad necesaria en una relacion muchos a muchos (productos y almacenes)
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        public string ProductId { get; set; }               // Relacion Ma1 con Productos, entidad ProductEntity, clave foranea - Cada almacen ...
        public ProductEntity Product { get; set; }          //

        public string WarehouseId { get; set; }             // Relacion Ma1 con bodegas, entidad WherehouseEntity
        public WarehouseEntity Warehouse { get; set; }      //

        public ICollection<InputOutputEntity> InputOutputs { get; set; } // Relacion 1aM con movimientos, entidad InputOutputEntity - 1 Movimiento puede contener en varios ...
    }
}
