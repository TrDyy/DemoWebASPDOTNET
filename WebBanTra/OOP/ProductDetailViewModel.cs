﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanTra.OOP
{
    [NotMapped]
    public class ProductDetailViewModel
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongTon { get; set; }
        public string TenDM { get; set; }
        public List<string> Images { get; set; }
        public List<string> Descriptions { get; set; }
        public string DanhMuc { get; set; }
        public List<ProductViewModel> SanPhamTuongTu { get; set; }

    }

}