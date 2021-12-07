using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class JenisKendaraan
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }
    }
}
