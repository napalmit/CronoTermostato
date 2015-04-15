// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2015-04-15 16:27:20Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
using System;
using System.ComponentModel;
using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
using System.Diagnostics;


public partial class Main : DataContext
{
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
	
	
	public Main(string connectionString) : 
			base(connectionString)
	{
		this.OnCreated();
	}
	
	public Main(string connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Table<TBlRegisTRaZionITemperaTURa> TBlRegisTRaZionITemperaTURa
	{
		get
		{
			return this.GetTable<TBlRegisTRaZionITemperaTURa>();
		}
	}
	
	public Table<TBlValorETemperaTURaManualE> TBlValorETemperaTURaManualE
	{
		get
		{
			return this.GetTable<TBlValorETemperaTURaManualE>();
		}
	}
}

#region Start MONO_STRICT
#if MONO_STRICT

public partial class Main
{
	
	public Main(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT

public partial class Main
{
	
	public Main(IDbConnection connection) : 
			base(connection, new DbLinq.Sqlite.SqliteVendor())
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, IVendor sqlDialect) : 
			base(connection, sqlDialect)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
			base(connection, mappingSource, sqlDialect)
	{
		this.OnCreated();
	}
}
#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
#endregion

[Table(Name="main.tbl_registrazioni_temperatura")]
public partial class TBlRegisTRaZionITemperaTURa : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.DateTime _dataRegisTrAZionE;
	
	private int _id;
	
	private double _valorE;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDataRegisTRaZionEChanged();
		
		partial void OnDataRegisTRaZionEChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnValorEChanged();
		
		partial void OnValorEChanging(double value);
		#endregion
	
	
	public TBlRegisTRaZionITemperaTURa()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_dataRegisTrAZionE", Name="data_registrazione", DbType="DATETIME", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public System.DateTime DataRegisTRaZionE
	{
		get
		{
			return this._dataRegisTrAZionE;
		}
		set
		{
			if ((_dataRegisTrAZionE != value))
			{
				this.OnDataRegisTRaZionEChanging(value);
				this.SendPropertyChanging();
				this._dataRegisTrAZionE = value;
				this.SendPropertyChanged("DataRegisTRaZionE");
				this.OnDataRegisTRaZionEChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_valorE", Name="valore", DbType="DOUBLE", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public double ValorE
	{
		get
		{
			return this._valorE;
		}
		set
		{
			if ((_valorE != value))
			{
				this.OnValorEChanging(value);
				this.SendPropertyChanging();
				this._valorE = value;
				this.SendPropertyChanged("ValorE");
				this.OnValorEChanged();
			}
		}
	}
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
}

[Table(Name="main.tbl_valore_temperatura_manuale")]
public partial class TBlValorETemperaTURaManualE : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.DateTime _dataModIfIca;
	
	private int _id;
	
	private double _valorE;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDataModIfIcaChanged();
		
		partial void OnDataModIfIcaChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnValorEChanged();
		
		partial void OnValorEChanging(double value);
		#endregion
	
	
	public TBlValorETemperaTURaManualE()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_dataModIfIca", Name="data_modifica", DbType="DATETIME", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public System.DateTime DataModIfIca
	{
		get
		{
			return this._dataModIfIca;
		}
		set
		{
			if ((_dataModIfIca != value))
			{
				this.OnDataModIfIcaChanging(value);
				this.SendPropertyChanging();
				this._dataModIfIca = value;
				this.SendPropertyChanged("DataModIfIca");
				this.OnDataModIfIcaChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_valorE", Name="valore", DbType="DOUBLE", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public double ValorE
	{
		get
		{
			return this._valorE;
		}
		set
		{
			if ((_valorE != value))
			{
				this.OnValorEChanging(value);
				this.SendPropertyChanging();
				this._valorE = value;
				this.SendPropertyChanged("ValorE");
				this.OnValorEChanged();
			}
		}
	}
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
}
