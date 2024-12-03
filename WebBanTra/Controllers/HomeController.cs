﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanTra.Models;
namespace WebBanTra.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            DB_BanTraEntities db = new DB_BanTraEntities();
            var spbc = db.ChiTietDHs.GroupBy(r=>r.MaSP).Select(g=> new 
            { 
                MaSP = g.Key, 
                SoLuong = g.Sum(r => r.SoLuongMua) ,
            }).OrderByDescending(g => g.SoLuong).Take(9).ToList();

            List<SanPham> sp = new List<SanPham>();
            List<Anh_SanPham> asp = new List<Anh_SanPham>();
            List<MoTa_SanPham> mtsp = new List<MoTa_SanPham>(); 
            foreach (var item in spbc)
            {
                sp.Add(db.SanPhams.Find(item.MaSP));
                asp.Add(db.AnhSanPhams.FirstOrDefault(r => r.MaSP == item.MaSP));
                mtsp.Add(db.MoTaSanPhams.FirstOrDefault(r => r.MaSP == item.MaSP));
            } 

            ViewBag.SanPhamBanChay = sp;
            ViewBag.AnhSanPhamBanChay = asp;
            ViewBag.MoTaSanPhamBanChay = mtsp;
            return View();
        }
    }
}