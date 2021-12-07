using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? IdKendaraan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? IdCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? IdJaminan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? Biaya { get; set; }
        public object IdCustomerNavigation { get; internal set; }
        public object IdJaminanNavigation { get; internal set; }
        public object IdKendaraanNavigation { get; internal set; }
        public ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
