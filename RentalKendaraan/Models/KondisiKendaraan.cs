using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class KondisiKendaraan
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Kondisi kendaraan tidak boleh kosong")]
        public string NamaKondisi { get; set; }
    }
}
