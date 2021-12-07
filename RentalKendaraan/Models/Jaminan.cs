using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Jaminan
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama Penjamin tidak boleh kosong")]
        public string NamaJaminan { get; set; }
    }
}
