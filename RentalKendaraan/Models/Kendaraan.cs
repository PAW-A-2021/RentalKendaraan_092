using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "Jenis kendaraan tidak boleh kosong")]
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Silahkan isi ketersediaan nya")]
        public string Ketersediaan { get; set; }
        public object IdJenisKendaraanNavigation { get; internal set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
