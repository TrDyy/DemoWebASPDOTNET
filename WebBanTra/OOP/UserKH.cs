﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebBanTra.Models;

namespace WebBanTra.OOP
{
    [NotMapped]
    public class UserKH
    {
        public KhachHang KhachHang { get; set; }
        public List<DonHang> listDonHang { get; set; }
        public List<ChiTietDH> ListChiTietDonHang { get; set; }
        public List<Anh_SanPham> listAnhSP { get; set; }

        public UserKH()
        {
            KhachHang = new KhachHang();
            listDonHang = new List<DonHang>();
            ListChiTietDonHang = new List<ChiTietDH>();
            listAnhSP = new List<Anh_SanPham>();
        }
    }
}