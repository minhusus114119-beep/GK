using System;
using System.Collections.Generic;
using System.Linq;
using QLXetNghiem.DAL.Model; // ← Đảm bảo namespace đúng
using System.Data.Entity; // ← DÒNG NÀY BẮT BUỘC

namespace QLXetNghiem.BUS
{
    public class NHANVIENBUS
    {
        // 1. Lấy danh sách hiển thị lên DataGridView (có tên công ty)
        public List<dynamic> GetAllNhanVien()
        {
            using (var context = new Model1()) // ← Tên DbContext đúng
            {
                var list = context.NHANVIENs
                    .Include("CONGTY") // ← Bắt buộc để lấy TenCty
                    .ToList();

                return list.Select(p => new
                {
                    ID = p.ID,
                    HoTen = p.HoTen,
                    SoLanXN = p.SoLanXN,
                    KetQua = p.AmTinh ? "Âm Tính" : "+",
                    TenCty = p.CONGTY?.TenCty // ← Hiển thị tên công ty
                }).Cast<dynamic>().ToList();
            }
        }

        public NHANVIEN FindById(string id)
        {
            using (var context = new Model1())
            {
                return context.NHANVIENs
                    .Include("CONGTY")
                    .FirstOrDefault(p => p.ID == id);
            }
        }

        public void InsertOrUpdate(NHANVIEN nv)
        {
            using (var context = new Model1())
            {
                var dbNv = context.NHANVIENs.Find(nv.ID);
                if (dbNv == null)
                {
                    context.NHANVIENs.Add(nv);
                }
                else
                {
                    dbNv.HoTen = nv.HoTen;
                    dbNv.SoLanXN = nv.SoLanXN;
                    dbNv.AmTinh = nv.AmTinh;
                    dbNv.MaCty = nv.MaCty;
                }
                context.SaveChanges();
            }
        }


        public List<dynamic> GetListDuongTinh()
        {
            using (var context = new Model1())
            {
                return context.NHANVIENs
                    .Where(p => !p.AmTinh)
                    .Select(p => new
                    {
                        ID = p.ID,
                        HoTen = p.HoTen,
                        SoLanXN = p.SoLanXN,
                        KetQua = "+"
                    }).Cast<dynamic>().ToList();
            }
        }
    }
}