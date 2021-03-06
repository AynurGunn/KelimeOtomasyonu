﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kelime_Otomasyonu.Fonksiyonlar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KelimeOtomasyonu")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Istatistik(tbl_Istatistik instance);
    partial void Updatetbl_Istatistik(tbl_Istatistik instance);
    partial void Deletetbl_Istatistik(tbl_Istatistik instance);
    partial void Inserttbl_Kelime(tbl_Kelime instance);
    partial void Updatetbl_Kelime(tbl_Kelime instance);
    partial void Deletetbl_Kelime(tbl_Kelime instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Kelime_Otomasyonu.Properties.Settings.Default.KelimeOtomasyonuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Istatistik> tbl_Istatistik
		{
			get
			{
				return this.GetTable<tbl_Istatistik>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Kelime> tbl_Kelime
		{
			get
			{
				return this.GetTable<tbl_Kelime>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Istatistik")]
	public partial class tbl_Istatistik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Aylar;
		
		private System.Nullable<int> _AyTarih;
		
		private System.Nullable<int> _BilinenKelimeSayisi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAylarChanging(string value);
    partial void OnAylarChanged();
    partial void OnAyTarihChanging(System.Nullable<int> value);
    partial void OnAyTarihChanged();
    partial void OnBilinenKelimeSayisiChanging(System.Nullable<int> value);
    partial void OnBilinenKelimeSayisiChanged();
    #endregion
		
		public tbl_Istatistik()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Aylar", DbType="NChar(10)")]
		public string Aylar
		{
			get
			{
				return this._Aylar;
			}
			set
			{
				if ((this._Aylar != value))
				{
					this.OnAylarChanging(value);
					this.SendPropertyChanging();
					this._Aylar = value;
					this.SendPropertyChanged("Aylar");
					this.OnAylarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AyTarih", DbType="Int")]
		public System.Nullable<int> AyTarih
		{
			get
			{
				return this._AyTarih;
			}
			set
			{
				if ((this._AyTarih != value))
				{
					this.OnAyTarihChanging(value);
					this.SendPropertyChanging();
					this._AyTarih = value;
					this.SendPropertyChanged("AyTarih");
					this.OnAyTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BilinenKelimeSayisi", DbType="Int")]
		public System.Nullable<int> BilinenKelimeSayisi
		{
			get
			{
				return this._BilinenKelimeSayisi;
			}
			set
			{
				if ((this._BilinenKelimeSayisi != value))
				{
					this.OnBilinenKelimeSayisiChanging(value);
					this.SendPropertyChanging();
					this._BilinenKelimeSayisi = value;
					this.SendPropertyChanged("BilinenKelimeSayisi");
					this.OnBilinenKelimeSayisiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Kelime")]
	public partial class tbl_Kelime : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Ingilizce;
		
		private string _Turkce;
		
		private string _Cumle;
		
		private System.Nullable<System.DateTime> _Tarih;
		
		private System.Nullable<int> _DogruBilme;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIngilizceChanging(string value);
    partial void OnIngilizceChanged();
    partial void OnTurkceChanging(string value);
    partial void OnTurkceChanged();
    partial void OnCumleChanging(string value);
    partial void OnCumleChanged();
    partial void OnTarihChanging(System.Nullable<System.DateTime> value);
    partial void OnTarihChanged();
    partial void OnDogruBilmeChanging(System.Nullable<int> value);
    partial void OnDogruBilmeChanged();
    #endregion
		
		public tbl_Kelime()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ingilizce", DbType="NVarChar(50)")]
		public string Ingilizce
		{
			get
			{
				return this._Ingilizce;
			}
			set
			{
				if ((this._Ingilizce != value))
				{
					this.OnIngilizceChanging(value);
					this.SendPropertyChanging();
					this._Ingilizce = value;
					this.SendPropertyChanged("Ingilizce");
					this.OnIngilizceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turkce", DbType="NVarChar(50)")]
		public string Turkce
		{
			get
			{
				return this._Turkce;
			}
			set
			{
				if ((this._Turkce != value))
				{
					this.OnTurkceChanging(value);
					this.SendPropertyChanging();
					this._Turkce = value;
					this.SendPropertyChanged("Turkce");
					this.OnTurkceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cumle", DbType="NVarChar(100)")]
		public string Cumle
		{
			get
			{
				return this._Cumle;
			}
			set
			{
				if ((this._Cumle != value))
				{
					this.OnCumleChanging(value);
					this.SendPropertyChanging();
					this._Cumle = value;
					this.SendPropertyChanged("Cumle");
					this.OnCumleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarih", DbType="DateTime")]
		public System.Nullable<System.DateTime> Tarih
		{
			get
			{
				return this._Tarih;
			}
			set
			{
				if ((this._Tarih != value))
				{
					this.OnTarihChanging(value);
					this.SendPropertyChanging();
					this._Tarih = value;
					this.SendPropertyChanged("Tarih");
					this.OnTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogruBilme", DbType="Int")]
		public System.Nullable<int> DogruBilme
		{
			get
			{
				return this._DogruBilme;
			}
			set
			{
				if ((this._DogruBilme != value))
				{
					this.OnDogruBilmeChanging(value);
					this.SendPropertyChanging();
					this._DogruBilme = value;
					this.SendPropertyChanged("DogruBilme");
					this.OnDogruBilmeChanged();
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
