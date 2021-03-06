﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuanLySachDatabaseFirst.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.BinhLuans = new HashSet<BinhLuan>();
            this.ChiTiet_HoaDon = new HashSet<ChiTiet_HoaDon>();
            this.SanPham_Size = new HashSet<SanPham_Size>();
        }
    
        public int MaSP { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm!")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không quá 100 ký tự")]
        public string TenSP { get; set; }
        public Nullable<long> GiaMua { get; set; }
        public Nullable<long> GiaBan { get; set; }
        public Nullable<int> LoaiSP { get; set; }
        public Nullable<int> ChuDe { get; set; }
        public string ThongTin { get; set; }
        public Nullable<int> GioiTinh { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> NgayNhapHang { get; set; }
        public string HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_HoaDon> ChiTiet_HoaDon { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham_Size> SanPham_Size { get; set; }
    }
}
