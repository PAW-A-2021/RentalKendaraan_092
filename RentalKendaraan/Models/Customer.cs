using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Customer
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka")]
        public string NoHp { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? IdGender { get; set; }
        public object IdGenderNavigation { get; internal set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
