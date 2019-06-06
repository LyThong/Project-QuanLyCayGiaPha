﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCayGiaPha
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCGP")]
	public partial class dulieuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKetThuc(KetThuc instance);
    partial void UpdateKetThuc(KetThuc instance);
    partial void DeleteKetThuc(KetThuc instance);
    partial void InsertNguoiDung(NguoiDung instance);
    partial void UpdateNguoiDung(NguoiDung instance);
    partial void DeleteNguoiDung(NguoiDung instance);
    partial void InsertThanhVien(ThanhVien instance);
    partial void UpdateThanhVien(ThanhVien instance);
    partial void DeleteThanhVien(ThanhVien instance);
    #endregion
		
		public dulieuDataContext() : 
				base(global::QuanLyCayGiaPha.Properties.Settings.Default.QLCGPConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dulieuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dulieuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dulieuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dulieuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GhiNhanThanhTich> GhiNhanThanhTiches
		{
			get
			{
				return this.GetTable<GhiNhanThanhTich>();
			}
		}
		
		public System.Data.Linq.Table<KetThuc> KetThucs
		{
			get
			{
				return this.GetTable<KetThuc>();
			}
		}
		
		public System.Data.Linq.Table<NguoiDung> NguoiDungs
		{
			get
			{
				return this.GetTable<NguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<ThanhVien> ThanhViens
		{
			get
			{
				return this.GetTable<ThanhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GhiNhanThanhTich")]
	public partial class GhiNhanThanhTich
	{
		
		private int _MaTT;
		
		private string _MaTV;
		
		private string _LoaiTT;
		
		private System.Nullable<System.DateTime> _NgayPS;
		
		public GhiNhanThanhTich()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTT", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MaTT
		{
			get
			{
				return this._MaTT;
			}
			set
			{
				if ((this._MaTT != value))
				{
					this._MaTT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTV", DbType="NChar(10)")]
		public string MaTV
		{
			get
			{
				return this._MaTV;
			}
			set
			{
				if ((this._MaTV != value))
				{
					this._MaTV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTT", DbType="NVarChar(50)")]
		public string LoaiTT
		{
			get
			{
				return this._LoaiTT;
			}
			set
			{
				if ((this._LoaiTT != value))
				{
					this._LoaiTT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayPS", DbType="Date")]
		public System.Nullable<System.DateTime> NgayPS
		{
			get
			{
				return this._NgayPS;
			}
			set
			{
				if ((this._NgayPS != value))
				{
					this._NgayPS = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KetThuc")]
	public partial class KetThuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKT;
		
		private string _MaTV;
		
		private string _NguyenNhan;
		
		private System.Nullable<System.DateTime> _NgayGio;
		
		private string _DiaDiemMT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKTChanging(int value);
    partial void OnMaKTChanged();
    partial void OnMaTVChanging(string value);
    partial void OnMaTVChanged();
    partial void OnNguyenNhanChanging(string value);
    partial void OnNguyenNhanChanged();
    partial void OnNgayGioChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGioChanged();
    partial void OnDiaDiemMTChanging(string value);
    partial void OnDiaDiemMTChanged();
    #endregion
		
		public KetThuc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKT
		{
			get
			{
				return this._MaKT;
			}
			set
			{
				if ((this._MaKT != value))
				{
					this.OnMaKTChanging(value);
					this.SendPropertyChanging();
					this._MaKT = value;
					this.SendPropertyChanged("MaKT");
					this.OnMaKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTV", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string MaTV
		{
			get
			{
				return this._MaTV;
			}
			set
			{
				if ((this._MaTV != value))
				{
					this.OnMaTVChanging(value);
					this.SendPropertyChanging();
					this._MaTV = value;
					this.SendPropertyChanged("MaTV");
					this.OnMaTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguyenNhan", DbType="NVarChar(50)")]
		public string NguyenNhan
		{
			get
			{
				return this._NguyenNhan;
			}
			set
			{
				if ((this._NguyenNhan != value))
				{
					this.OnNguyenNhanChanging(value);
					this.SendPropertyChanging();
					this._NguyenNhan = value;
					this.SendPropertyChanged("NguyenNhan");
					this.OnNguyenNhanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGio", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayGio
		{
			get
			{
				return this._NgayGio;
			}
			set
			{
				if ((this._NgayGio != value))
				{
					this.OnNgayGioChanging(value);
					this.SendPropertyChanging();
					this._NgayGio = value;
					this.SendPropertyChanged("NgayGio");
					this.OnNgayGioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaDiemMT", DbType="NVarChar(50)")]
		public string DiaDiemMT
		{
			get
			{
				return this._DiaDiemMT;
			}
			set
			{
				if ((this._DiaDiemMT != value))
				{
					this.OnDiaDiemMTChanging(value);
					this.SendPropertyChanging();
					this._DiaDiemMT = value;
					this.SendPropertyChanged("DiaDiemMT");
					this.OnDiaDiemMTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguoiDung")]
	public partial class NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoan;
		
		private string _matkhau;
		
		private string _ChucVu;
		
		private string _HoTen;
		
		private string _DiaChi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public NguoiDung()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NChar(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="NChar(10)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(50)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThanhVien")]
	public partial class ThanhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTV;
		
		private string _HoTenTVC;
		
		private string _HoTenTVM;
		
		private string _QueQuan;
		
		private string _LoaiQuanHe;
		
		private string _GioiTinh;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<System.DateTime> _NgayPhatSinh;
		
		private string _NgheNghiep;
		
		private string _DiaChi;
		
		private System.Data.Linq.Binary _HinhAnh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTVChanging(string value);
    partial void OnMaTVChanged();
    partial void OnHoTenTVCChanging(string value);
    partial void OnHoTenTVCChanged();
    partial void OnHoTenTVMChanging(string value);
    partial void OnHoTenTVMChanged();
    partial void OnQueQuanChanging(string value);
    partial void OnQueQuanChanged();
    partial void OnLoaiQuanHeChanging(string value);
    partial void OnLoaiQuanHeChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnNgayPhatSinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayPhatSinhChanged();
    partial void OnNgheNghiepChanging(string value);
    partial void OnNgheNghiepChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnHinhAnhChanging(System.Data.Linq.Binary value);
    partial void OnHinhAnhChanged();
    #endregion
		
		public ThanhVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTV
		{
			get
			{
				return this._MaTV;
			}
			set
			{
				if ((this._MaTV != value))
				{
					this.OnMaTVChanging(value);
					this.SendPropertyChanging();
					this._MaTV = value;
					this.SendPropertyChanged("MaTV");
					this.OnMaTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTenTVC", DbType="NVarChar(50)")]
		public string HoTenTVC
		{
			get
			{
				return this._HoTenTVC;
			}
			set
			{
				if ((this._HoTenTVC != value))
				{
					this.OnHoTenTVCChanging(value);
					this.SendPropertyChanging();
					this._HoTenTVC = value;
					this.SendPropertyChanged("HoTenTVC");
					this.OnHoTenTVCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTenTVM", DbType="NVarChar(50)")]
		public string HoTenTVM
		{
			get
			{
				return this._HoTenTVM;
			}
			set
			{
				if ((this._HoTenTVM != value))
				{
					this.OnHoTenTVMChanging(value);
					this.SendPropertyChanging();
					this._HoTenTVM = value;
					this.SendPropertyChanged("HoTenTVM");
					this.OnHoTenTVMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QueQuan", DbType="NVarChar(50)")]
		public string QueQuan
		{
			get
			{
				return this._QueQuan;
			}
			set
			{
				if ((this._QueQuan != value))
				{
					this.OnQueQuanChanging(value);
					this.SendPropertyChanging();
					this._QueQuan = value;
					this.SendPropertyChanged("QueQuan");
					this.OnQueQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiQuanHe", DbType="NVarChar(50)")]
		public string LoaiQuanHe
		{
			get
			{
				return this._LoaiQuanHe;
			}
			set
			{
				if ((this._LoaiQuanHe != value))
				{
					this.OnLoaiQuanHeChanging(value);
					this.SendPropertyChanging();
					this._LoaiQuanHe = value;
					this.SendPropertyChanged("LoaiQuanHe");
					this.OnLoaiQuanHeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(50)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayPhatSinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgayPhatSinh
		{
			get
			{
				return this._NgayPhatSinh;
			}
			set
			{
				if ((this._NgayPhatSinh != value))
				{
					this.OnNgayPhatSinhChanging(value);
					this.SendPropertyChanging();
					this._NgayPhatSinh = value;
					this.SendPropertyChanged("NgayPhatSinh");
					this.OnNgayPhatSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgheNghiep", DbType="NVarChar(50)")]
		public string NgheNghiep
		{
			get
			{
				return this._NgheNghiep;
			}
			set
			{
				if ((this._NgheNghiep != value))
				{
					this.OnNgheNghiepChanging(value);
					this.SendPropertyChanging();
					this._NgheNghiep = value;
					this.SendPropertyChanged("NgheNghiep");
					this.OnNgheNghiepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
