﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04LINQ_TO_SQL_FORM_UN_REGISTRO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hospital")]
	public partial class ClsEnfermosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertENFERMO(ENFERMO instance);
    partial void UpdateENFERMO(ENFERMO instance);
    partial void DeleteENFERMO(ENFERMO instance);
    #endregion
		
		public ClsEnfermosDataContext() : 
				base(global::_04LINQ_TO_SQL_FORM_UN_REGISTRO.Properties.Settings.Default.HospitalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClsEnfermosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClsEnfermosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClsEnfermosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClsEnfermosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ENFERMO> ENFERMO
		{
			get
			{
				return this.GetTable<ENFERMO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ENFERMO")]
	public partial class ENFERMO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _INSCRIPCION;
		
		private string _APELLIDO;
		
		private string _DIRECCION;
		
		private System.Nullable<System.DateTime> _FECHA_NAC;
		
		private string _S;
		
		private string _NSS;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnINSCRIPCIONChanging(string value);
    partial void OnINSCRIPCIONChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    partial void OnFECHA_NACChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHA_NACChanged();
    partial void OnSChanging(string value);
    partial void OnSChanged();
    partial void OnNSSChanging(string value);
    partial void OnNSSChanged();
    #endregion
		
		public ENFERMO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INSCRIPCION", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string INSCRIPCION
		{
			get
			{
				return this._INSCRIPCION;
			}
			set
			{
				if ((this._INSCRIPCION != value))
				{
					this.OnINSCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._INSCRIPCION = value;
					this.SendPropertyChanged("INSCRIPCION");
					this.OnINSCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_NAC", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_NAC
		{
			get
			{
				return this._FECHA_NAC;
			}
			set
			{
				if ((this._FECHA_NAC != value))
				{
					this.OnFECHA_NACChanging(value);
					this.SendPropertyChanging();
					this._FECHA_NAC = value;
					this.SendPropertyChanged("FECHA_NAC");
					this.OnFECHA_NACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="NVarChar(50)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this.OnSChanging(value);
					this.SendPropertyChanging();
					this._S = value;
					this.SendPropertyChanged("S");
					this.OnSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="NVarChar(50)")]
		public string NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this.OnNSSChanging(value);
					this.SendPropertyChanging();
					this._NSS = value;
					this.SendPropertyChanged("NSS");
					this.OnNSSChanged();
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
