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

namespace Gym_management_appication
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GymManagement")]
	public partial class MainDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    #endregion
		
		public MainDataClassesDataContext() : 
				base(global::Gym_management_appication.Properties.Settings.Default.GymManagementConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public MainDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Member")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ma;
		
		private string _ten;
		
		private System.Nullable<int> _tuoi;
		
		private string _gioiTinh;
		
		private System.Nullable<long> _soDT;
		
		private System.Nullable<System.DateTime> _ngayThamGia;
		
		private System.Nullable<System.DateTime> _ngayKetThuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaChanging(string value);
    partial void OnmaChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OntuoiChanging(System.Nullable<int> value);
    partial void OntuoiChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnsoDTChanging(System.Nullable<long> value);
    partial void OnsoDTChanged();
    partial void OnngayThamGiaChanging(System.Nullable<System.DateTime> value);
    partial void OnngayThamGiaChanged();
    partial void OnngayKetThucChanging(System.Nullable<System.DateTime> value);
    partial void OnngayKetThucChanged();
    #endregion
		
		public Member()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ma", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ma
		{
			get
			{
				return this._ma;
			}
			set
			{
				if ((this._ma != value))
				{
					this.OnmaChanging(value);
					this.SendPropertyChanging();
					this._ma = value;
					this.SendPropertyChanged("ma");
					this.OnmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(50)")]
		public string ten
		{
			get
			{
				return this._ten;
			}
			set
			{
				if ((this._ten != value))
				{
					this.OntenChanging(value);
					this.SendPropertyChanging();
					this._ten = value;
					this.SendPropertyChanged("ten");
					this.OntenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tuoi", DbType="Int")]
		public System.Nullable<int> tuoi
		{
			get
			{
				return this._tuoi;
			}
			set
			{
				if ((this._tuoi != value))
				{
					this.OntuoiChanging(value);
					this.SendPropertyChanging();
					this._tuoi = value;
					this.SendPropertyChanged("tuoi");
					this.OntuoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NChar(10)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soDT", DbType="BigInt")]
		public System.Nullable<long> soDT
		{
			get
			{
				return this._soDT;
			}
			set
			{
				if ((this._soDT != value))
				{
					this.OnsoDTChanging(value);
					this.SendPropertyChanging();
					this._soDT = value;
					this.SendPropertyChanged("soDT");
					this.OnsoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayThamGia", DbType="Date")]
		public System.Nullable<System.DateTime> ngayThamGia
		{
			get
			{
				return this._ngayThamGia;
			}
			set
			{
				if ((this._ngayThamGia != value))
				{
					this.OnngayThamGiaChanging(value);
					this.SendPropertyChanging();
					this._ngayThamGia = value;
					this.SendPropertyChanged("ngayThamGia");
					this.OnngayThamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayKetThuc", DbType="Date")]
		public System.Nullable<System.DateTime> ngayKetThuc
		{
			get
			{
				return this._ngayKetThuc;
			}
			set
			{
				if ((this._ngayKetThuc != value))
				{
					this.OnngayKetThucChanging(value);
					this.SendPropertyChanging();
					this._ngayKetThuc = value;
					this.SendPropertyChanged("ngayKetThuc");
					this.OnngayKetThucChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _HoTen;
		
		private string _GioiTinh;
		
		private string _Email;
		
		private long _SoDT;
		
		private string _DiaChi;
		
		private string _ChucVu;
		
		private decimal _Luong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDTChanging(long value);
    partial void OnSoDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnLuongChanging(decimal value);
    partial void OnLuongChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(32) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NChar(32) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NChar(10) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(32) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDT", DbType="BigInt NOT NULL")]
		public long SoDT
		{
			get
			{
				return this._SoDT;
			}
			set
			{
				if ((this._SoDT != value))
				{
					this.OnSoDTChanging(value);
					this.SendPropertyChanging();
					this._SoDT = value;
					this.SendPropertyChanged("SoDT");
					this.OnSoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NChar(10) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Luong", DbType="Money NOT NULL")]
		public decimal Luong
		{
			get
			{
				return this._Luong;
			}
			set
			{
				if ((this._Luong != value))
				{
					this.OnLuongChanging(value);
					this.SendPropertyChanging();
					this._Luong = value;
					this.SendPropertyChanged("Luong");
					this.OnLuongChanged();
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
