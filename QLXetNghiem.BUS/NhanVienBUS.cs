using QLXetNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity; // ← DÒNG NÀY BẮT BUỘC

namespace QLXetNghiem.BUS
{
    public class NhanVienService
    {
        // 1. Lấy danh sách hiển thị lên DataGridView
        public List<dynamic> GetAllNhanVien()
        {
            using (var context = new Model1())
            {
                var list = context.NHANVIENs.ToList();

                // Trả về dynamic để GridView tự nhận các cột và xử lý hiển thị
                return list.Select(p => new
                {
                    ID = p.ID,                 // CMND/CCCD
                    HoTen = p.HoTen,           // Họ và Tên
                    SoLanXN = p.SoLanXN,       // Số lần XN
                    KetQua = p.AmTinh == true ? "Âm Tính" : "+", // Xử lý hiển thị Âm tính/Dương tính
                    MaCty = p.MaCty

                }).Cast<dynamic>().ToList();
            }
        }

        // 2. Tìm nhân viên theo ID
        public NHANVIEN FindById(string id)
        {
            using (var context = new Model1())
            {
                return context.NHANVIENs.FirstOrDefault(p => p.ID == id);
            }
        }

        // 3. Thêm hoặc Cập nhật nhân viên
        public void InsertOrUpdate(NHANVIEN nv)
        {
            using (var context = new Model1())
            {
                var dbNv = context.NHANVIENs.FirstOrDefault(p => p.ID == nv.ID);

                if (dbNv == null)
                {
                    // Chưa có thì Thêm mới
                    context.NHANVIENs.Add(nv);
                }
                else
                {
                    // Có rồi thì Cập nhật
                    dbNv.HoTen = nv.HoTen;
                    dbNv.SoLanXN = nv.SoLanXN;
                    dbNv.AmTinh = nv.AmTinh;
                    dbNv.MaCty = nv.MaCty;
                }
                context.SaveChanges();
            }
        }

        // 4. Lấy danh sách Dương Tính (Phục vụ Menu F1)
        public List<dynamic> GetListDuongTinh()
        {
            using (var context = new Model1())
            {
                var list = context.NHANVIENs.Where(p => p.AmTinh == false).ToList();

                return list.Select(p => new
                {
                    ID = p.ID,
                    HoTen = p.HoTen,
                    SoLanXN = p.SoLanXN,
                    KetQua = "+"
                }).Cast<dynamic>().ToList();
            }
        }


        public List<NHANVIEN> GetNhanVienByCongTy(string maCty)
        {
            using (var context = new Model1())
            {
                // Lấy nhân viên thuộc công ty đó
                return context.NHANVIENs.Where(p => p.MaCty == maCty).ToList();
            }
        }
    }
}