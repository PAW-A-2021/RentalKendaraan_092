using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdGender { get; set; }
        [Required(ErrorMessage = "Gender tidak boleh kosong")]
        public string NamaGender { get; set; }
    }
}
