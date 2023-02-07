using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEntity  // Entidad que contiene los movimientos de entrada y salida que han ocurridos.
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

        public string StorageId { get; set; } // Relacion con almacenamiento, entidad StorageEntity
        public StorageEntity Storage { get; set; } // Relacion 1aM con almacenamiento, entidad StorageEntity - 1 Producto puede estar en varios almacenes
    }
}
