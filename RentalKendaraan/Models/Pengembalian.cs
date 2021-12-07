using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }
        public object IdKondisiNavigation { get; internal set; }
        public object IdPeminjamanNavigation { get; internal set; }
    }
}
