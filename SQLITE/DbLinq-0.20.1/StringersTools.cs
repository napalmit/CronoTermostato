// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2012-01-04 12:06:04Z.
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
	
	public Table<ReLOperatorsCustomers> ReLOperatorsCustomers
	{
		get
		{
			return this.GetTable<ReLOperatorsCustomers>();
		}
	}
	
	public Table<ReLOperatorsStringers> ReLOperatorsStringers
	{
		get
		{
			return this.GetTable<ReLOperatorsStringers>();
		}
	}
	
	public Table<TBlBrands> TBlBrands
	{
		get
		{
			return this.GetTable<TBlBrands>();
		}
	}
	
	public Table<TBlCc> TBlCc
	{
		get
		{
			return this.GetTable<TBlCc>();
		}
	}
	
	public Table<TBlPayment> TBlPayment
	{
		get
		{
			return this.GetTable<TBlPayment>();
		}
	}
	
	public Table<TBlRoles> TBlRoles
	{
		get
		{
			return this.GetTable<TBlRoles>();
		}
	}
	
	public Table<TBlUsers> TBlUsers
	{
		get
		{
			return this.GetTable<TBlUsers>();
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

[Table(Name="main.rel_operators_customers")]
public partial class ReLOperatorsCustomers
{
	
	private int _idcUstomer;
	
	private int _idoPerator;
	
	private EntitySet<TBlUsers> _tbLUsers;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDCustomerChanged();
		
		partial void OnIDCustomerChanging(int value);
		
		partial void OnIDOperatorChanged();
		
		partial void OnIDOperatorChanging(int value);
		#endregion
	
	
	public ReLOperatorsCustomers()
	{
		_tbLUsers = new EntitySet<TBlUsers>(new Action<TBlUsers>(this.TBlUsers_Attach), new Action<TBlUsers>(this.TBlUsers_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_idcUstomer", Name="id_customer", DbType="integer", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int IDCustomer
	{
		get
		{
			return this._idcUstomer;
		}
		set
		{
			if ((_idcUstomer != value))
			{
				this.OnIDCustomerChanging(value);
				this._idcUstomer = value;
				this.OnIDCustomerChanged();
			}
		}
	}
	
	[Column(Storage="_idoPerator", Name="id_operator", DbType="integer", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int IDOperator
	{
		get
		{
			return this._idoPerator;
		}
		set
		{
			if ((_idoPerator != value))
			{
				this.OnIDOperatorChanging(value);
				this._idoPerator = value;
				this.OnIDOperatorChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_tbLUsers", OtherKey="ID", ThisKey="IDOperator", Name="fk_tbl_users_3")]
	[DebuggerNonUserCode()]
	public EntitySet<TBlUsers> TBlUsers
	{
		get
		{
			return this._tbLUsers;
		}
		set
		{
			this._tbLUsers = value;
		}
	}
	#endregion
	
	#region Attachment handlers
	private void TBlUsers_Attach(TBlUsers entity)
	{
		entity.ReLOperatorsCustomers = this;
	}
	
	private void TBlUsers_Detach(TBlUsers entity)
	{
		entity.ReLOperatorsCustomers = null;
	}
	#endregion
}

[Table(Name="main.rel_operators_stringers")]
public partial class ReLOperatorsStringers : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _idoPerator;
	
	private System.Nullable<int> _idsTringer;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDOperatorChanged();
		
		partial void OnIDOperatorChanging(System.Nullable<int> value);
		
		partial void OnIDStringerChanged();
		
		partial void OnIDStringerChanging(System.Nullable<int> value);
		#endregion
	
	
	public ReLOperatorsStringers()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_idoPerator", Name="id_operator", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDOperator
	{
		get
		{
			return this._idoPerator;
		}
		set
		{
			if ((_idoPerator != value))
			{
				this.OnIDOperatorChanging(value);
				this.SendPropertyChanging();
				this._idoPerator = value;
				this.SendPropertyChanged("IDOperator");
				this.OnIDOperatorChanged();
			}
		}
	}
	
	[Column(Storage="_idsTringer", Name="id_stringer", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDStringer
	{
		get
		{
			return this._idsTringer;
		}
		set
		{
			if ((_idsTringer != value))
			{
				this.OnIDStringerChanging(value);
				this.SendPropertyChanging();
				this._idsTringer = value;
				this.SendPropertyChanged("IDStringer");
				this.OnIDStringerChanged();
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

[Table(Name="main.tbl_brands")]
public partial class TBlBrands : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.DateTime _dateMod;
	
	private string _description;
	
	private int _id;
	
	private int _iduSerMod;
	
	private string _name;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateModChanged();
		
		partial void OnDateModChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIDUserModChanged();
		
		partial void OnIDUserModChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		#endregion
	
	
	public TBlBrands()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_dateMod", Name="date_mod", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public System.DateTime DateMod
	{
		get
		{
			return this._dateMod;
		}
		set
		{
			if ((_dateMod != value))
			{
				this.OnDateModChanging(value);
				this.SendPropertyChanging();
				this._dateMod = value;
				this.SendPropertyChanged("DateMod");
				this.OnDateModChanged();
			}
		}
	}
	
	[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
		set
		{
			if (((_description == value) 
						== false))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
	
	[Column(Storage="_iduSerMod", Name="id_user_mod", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int IDUserMod
	{
		get
		{
			return this._iduSerMod;
		}
		set
		{
			if ((_iduSerMod != value))
			{
				this.OnIDUserModChanging(value);
				this.SendPropertyChanging();
				this._iduSerMod = value;
				this.SendPropertyChanged("IDUserMod");
				this.OnIDUserModChanged();
			}
		}
	}
	
	[Column(Storage="_name", Name="name", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			if (((_name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
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

[Table(Name="main.tbl_cc")]
public partial class TBlCc : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _id;
	
	private EntitySet<TBlUsers> _tbLUsers;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		#endregion
	
	
	public TBlCc()
	{
		_tbLUsers = new EntitySet<TBlUsers>(new Action<TBlUsers>(this.TBlUsers_Attach), new Action<TBlUsers>(this.TBlUsers_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_description", Name="description", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
		set
		{
			if (((_description == value) 
						== false))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="integer", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
	
	#region Children
	[Association(Storage="_tbLUsers", OtherKey="IDCcType", ThisKey="ID", Name="fk_tbl_users_0")]
	[DebuggerNonUserCode()]
	public EntitySet<TBlUsers> TBlUsers
	{
		get
		{
			return this._tbLUsers;
		}
		set
		{
			this._tbLUsers = value;
		}
	}
	#endregion
	
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
	
	#region Attachment handlers
	private void TBlUsers_Attach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlCc = this;
	}
	
	private void TBlUsers_Detach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlCc = null;
	}
	#endregion
}

[Table(Name="main.tbl_payment")]
public partial class TBlPayment : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _id;
	
	private string _language;
	
	private EntitySet<TBlUsers> _tbLUsers;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnLanguageChanged();
		
		partial void OnLanguageChanging(string value);
		#endregion
	
	
	public TBlPayment()
	{
		_tbLUsers = new EntitySet<TBlUsers>(new Action<TBlUsers>(this.TBlUsers_Attach), new Action<TBlUsers>(this.TBlUsers_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_description", Name="description", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
		set
		{
			if (((_description == value) 
						== false))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
	
	[Column(Storage="_language", Name="language", DbType="char(5)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Language
	{
		get
		{
			return this._language;
		}
		set
		{
			if (((_language == value) 
						== false))
			{
				this.OnLanguageChanging(value);
				this.SendPropertyChanging();
				this._language = value;
				this.SendPropertyChanged("Language");
				this.OnLanguageChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_tbLUsers", OtherKey="IDPayment", ThisKey="ID", Name="fk_tbl_users_1")]
	[DebuggerNonUserCode()]
	public EntitySet<TBlUsers> TBlUsers
	{
		get
		{
			return this._tbLUsers;
		}
		set
		{
			this._tbLUsers = value;
		}
	}
	#endregion
	
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
	
	#region Attachment handlers
	private void TBlUsers_Attach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlPayment = this;
	}
	
	private void TBlUsers_Detach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlPayment = null;
	}
	#endregion
}

[Table(Name="main.tbl_roles")]
public partial class TBlRoles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _description;
	
	private int _id;
	
	private EntitySet<TBlUsers> _tbLUsers;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		#endregion
	
	
	public TBlRoles()
	{
		_tbLUsers = new EntitySet<TBlUsers>(new Action<TBlUsers>(this.TBlUsers_Attach), new Action<TBlUsers>(this.TBlUsers_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_description", Name="description", DbType="VARCHAR(20)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
		set
		{
			if (((_description == value) 
						== false))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
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
	
	#region Children
	[Association(Storage="_tbLUsers", OtherKey="IDRole", ThisKey="ID", Name="fk_tbl_users_2")]
	[DebuggerNonUserCode()]
	public EntitySet<TBlUsers> TBlUsers
	{
		get
		{
			return this._tbLUsers;
		}
		set
		{
			this._tbLUsers = value;
		}
	}
	#endregion
	
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
	
	#region Attachment handlers
	private void TBlUsers_Attach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlRoles = this;
	}
	
	private void TBlUsers_Detach(TBlUsers entity)
	{
		this.SendPropertyChanging();
		entity.TBlRoles = null;
	}
	#endregion
}

[Table(Name="main.tbl_users")]
public partial class TBlUsers : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _accountData;
	
	private System.Nullable<int> _active;
	
	private string _address1;
	
	private string _cap1;
	
	private System.Nullable<int> _ccCcV;
	
	private System.Nullable<int> _ccMonth;
	
	private string _ccName;
	
	private string _ccNumber;
	
	private System.Nullable<int> _ccYear;
	
	private string _city1;
	
	private System.Nullable<System.DateTime> _dateMod;
	
	private string _email;
	
	private int _id;
	
	private System.Nullable<int> _idcCType;
	
	private System.Nullable<int> _idpAyment;
	
	private System.Nullable<int> _idrOle;
	
	private System.Nullable<int> _iduSerMod;
	
	private string _name;
	
	private string _password;
	
	private string _province1;
	
	private string _state1;
	
	private string _surname;
	
	private string _telephone1;
	
	private string _telephone2;
	
	private string _userName;
	
	private EntityRef<TBlCc> _tbLCc = new EntityRef<TBlCc>();
	
	private EntityRef<TBlPayment> _tbLPayment = new EntityRef<TBlPayment>();
	
	private EntityRef<TBlRoles> _tbLRoles = new EntityRef<TBlRoles>();
	
	private EntityRef<ReLOperatorsCustomers> _reLoPeratorsCustomers = new EntityRef<ReLOperatorsCustomers>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccountDataChanged();
		
		partial void OnAccountDataChanging(string value);
		
		partial void OnActiveChanged();
		
		partial void OnActiveChanging(System.Nullable<int> value);
		
		partial void OnAddress1Changed();
		
		partial void OnAddress1Changing(string value);
		
		partial void OnCap1Changed();
		
		partial void OnCap1Changing(string value);
		
		partial void OnCcCcVChanged();
		
		partial void OnCcCcVChanging(System.Nullable<int> value);
		
		partial void OnCcMonthChanged();
		
		partial void OnCcMonthChanging(System.Nullable<int> value);
		
		partial void OnCcNameChanged();
		
		partial void OnCcNameChanging(string value);
		
		partial void OnCcNumberChanged();
		
		partial void OnCcNumberChanging(string value);
		
		partial void OnCcYearChanged();
		
		partial void OnCcYearChanging(System.Nullable<int> value);
		
		partial void OnCity1Changed();
		
		partial void OnCity1Changing(string value);
		
		partial void OnDateModChanged();
		
		partial void OnDateModChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIDCcTypeChanged();
		
		partial void OnIDCcTypeChanging(System.Nullable<int> value);
		
		partial void OnIDPaymentChanged();
		
		partial void OnIDPaymentChanging(System.Nullable<int> value);
		
		partial void OnIDRoleChanged();
		
		partial void OnIDRoleChanging(System.Nullable<int> value);
		
		partial void OnIDUserModChanged();
		
		partial void OnIDUserModChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		
		partial void OnProvince1Changed();
		
		partial void OnProvince1Changing(string value);
		
		partial void OnState1Changed();
		
		partial void OnState1Changing(string value);
		
		partial void OnSurnameChanged();
		
		partial void OnSurnameChanging(string value);
		
		partial void OnTelephone1Changed();
		
		partial void OnTelephone1Changing(string value);
		
		partial void OnTelephone2Changed();
		
		partial void OnTelephone2Changing(string value);
		
		partial void OnUserNameChanged();
		
		partial void OnUserNameChanging(string value);
		#endregion
	
	
	public TBlUsers()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_accountData", Name="account_data", DbType="text", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string AccountData
	{
		get
		{
			return this._accountData;
		}
		set
		{
			if (((_accountData == value) 
						== false))
			{
				this.OnAccountDataChanging(value);
				this.SendPropertyChanging();
				this._accountData = value;
				this.SendPropertyChanged("AccountData");
				this.OnAccountDataChanged();
			}
		}
	}
	
	[Column(Storage="_active", Name="active", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Active
	{
		get
		{
			return this._active;
		}
		set
		{
			if ((_active != value))
			{
				this.OnActiveChanging(value);
				this.SendPropertyChanging();
				this._active = value;
				this.SendPropertyChanged("Active");
				this.OnActiveChanged();
			}
		}
	}
	
	[Column(Storage="_address1", Name="address_1", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Address1
	{
		get
		{
			return this._address1;
		}
		set
		{
			if (((_address1 == value) 
						== false))
			{
				this.OnAddress1Changing(value);
				this.SendPropertyChanging();
				this._address1 = value;
				this.SendPropertyChanged("Address1");
				this.OnAddress1Changed();
			}
		}
	}
	
	[Column(Storage="_cap1", Name="cap_1", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Cap1
	{
		get
		{
			return this._cap1;
		}
		set
		{
			if (((_cap1 == value) 
						== false))
			{
				this.OnCap1Changing(value);
				this.SendPropertyChanging();
				this._cap1 = value;
				this.SendPropertyChanged("Cap1");
				this.OnCap1Changed();
			}
		}
	}
	
	[Column(Storage="_ccCcV", Name="cc_ccv", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CcCcV
	{
		get
		{
			return this._ccCcV;
		}
		set
		{
			if ((_ccCcV != value))
			{
				this.OnCcCcVChanging(value);
				this.SendPropertyChanging();
				this._ccCcV = value;
				this.SendPropertyChanged("CcCcV");
				this.OnCcCcVChanged();
			}
		}
	}
	
	[Column(Storage="_ccMonth", Name="cc_month", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CcMonth
	{
		get
		{
			return this._ccMonth;
		}
		set
		{
			if ((_ccMonth != value))
			{
				this.OnCcMonthChanging(value);
				this.SendPropertyChanging();
				this._ccMonth = value;
				this.SendPropertyChanged("CcMonth");
				this.OnCcMonthChanged();
			}
		}
	}
	
	[Column(Storage="_ccName", Name="cc_name", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string CcName
	{
		get
		{
			return this._ccName;
		}
		set
		{
			if (((_ccName == value) 
						== false))
			{
				this.OnCcNameChanging(value);
				this.SendPropertyChanging();
				this._ccName = value;
				this.SendPropertyChanged("CcName");
				this.OnCcNameChanged();
			}
		}
	}
	
	[Column(Storage="_ccNumber", Name="cc_number", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string CcNumber
	{
		get
		{
			return this._ccNumber;
		}
		set
		{
			if (((_ccNumber == value) 
						== false))
			{
				this.OnCcNumberChanging(value);
				this.SendPropertyChanging();
				this._ccNumber = value;
				this.SendPropertyChanged("CcNumber");
				this.OnCcNumberChanged();
			}
		}
	}
	
	[Column(Storage="_ccYear", Name="cc_year", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CcYear
	{
		get
		{
			return this._ccYear;
		}
		set
		{
			if ((_ccYear != value))
			{
				this.OnCcYearChanging(value);
				this.SendPropertyChanging();
				this._ccYear = value;
				this.SendPropertyChanged("CcYear");
				this.OnCcYearChanged();
			}
		}
	}
	
	[Column(Storage="_city1", Name="city_1", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string City1
	{
		get
		{
			return this._city1;
		}
		set
		{
			if (((_city1 == value) 
						== false))
			{
				this.OnCity1Changing(value);
				this.SendPropertyChanging();
				this._city1 = value;
				this.SendPropertyChanged("City1");
				this.OnCity1Changed();
			}
		}
	}
	
	[Column(Storage="_dateMod", Name="date_mod", DbType="timestamp", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<System.DateTime> DateMod
	{
		get
		{
			return this._dateMod;
		}
		set
		{
			if ((_dateMod != value))
			{
				this.OnDateModChanging(value);
				this.SendPropertyChanging();
				this._dateMod = value;
				this.SendPropertyChanged("DateMod");
				this.OnDateModChanged();
			}
		}
	}
	
	[Column(Storage="_email", Name="email", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Email
	{
		get
		{
			return this._email;
		}
		set
		{
			if (((_email == value) 
						== false))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="id", DbType="integer", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
	
	[Column(Storage="_idcCType", Name="id_cc_type", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDCcType
	{
		get
		{
			return this._idcCType;
		}
		set
		{
			if ((_idcCType != value))
			{
				this.OnIDCcTypeChanging(value);
				this.SendPropertyChanging();
				this._idcCType = value;
				this.SendPropertyChanged("IDCcType");
				this.OnIDCcTypeChanged();
			}
		}
	}
	
	[Column(Storage="_idpAyment", Name="id_payment", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDPayment
	{
		get
		{
			return this._idpAyment;
		}
		set
		{
			if ((_idpAyment != value))
			{
				this.OnIDPaymentChanging(value);
				this.SendPropertyChanging();
				this._idpAyment = value;
				this.SendPropertyChanged("IDPayment");
				this.OnIDPaymentChanged();
			}
		}
	}
	
	[Column(Storage="_idrOle", Name="id_role", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDRole
	{
		get
		{
			return this._idrOle;
		}
		set
		{
			if ((_idrOle != value))
			{
				this.OnIDRoleChanging(value);
				this.SendPropertyChanging();
				this._idrOle = value;
				this.SendPropertyChanged("IDRole");
				this.OnIDRoleChanged();
			}
		}
	}
	
	[Column(Storage="_iduSerMod", Name="id_user_mod", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> IDUserMod
	{
		get
		{
			return this._iduSerMod;
		}
		set
		{
			if ((_iduSerMod != value))
			{
				this.OnIDUserModChanging(value);
				this.SendPropertyChanging();
				this._iduSerMod = value;
				this.SendPropertyChanged("IDUserMod");
				this.OnIDUserModChanged();
			}
		}
	}
	
	[Column(Storage="_name", Name="name", DbType="varchar(25)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			if (((_name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[Column(Storage="_password", Name="password", DbType="varchar(15)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Password
	{
		get
		{
			return this._password;
		}
		set
		{
			if (((_password == value) 
						== false))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[Column(Storage="_province1", Name="province_1", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Province1
	{
		get
		{
			return this._province1;
		}
		set
		{
			if (((_province1 == value) 
						== false))
			{
				this.OnProvince1Changing(value);
				this.SendPropertyChanging();
				this._province1 = value;
				this.SendPropertyChanged("Province1");
				this.OnProvince1Changed();
			}
		}
	}
	
	[Column(Storage="_state1", Name="state_1", DbType="varchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string State1
	{
		get
		{
			return this._state1;
		}
		set
		{
			if (((_state1 == value) 
						== false))
			{
				this.OnState1Changing(value);
				this.SendPropertyChanging();
				this._state1 = value;
				this.SendPropertyChanged("State1");
				this.OnState1Changed();
			}
		}
	}
	
	[Column(Storage="_surname", Name="surname", DbType="varchar(25)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Surname
	{
		get
		{
			return this._surname;
		}
		set
		{
			if (((_surname == value) 
						== false))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[Column(Storage="_telephone1", Name="telephone_1", DbType="varchar(20)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Telephone1
	{
		get
		{
			return this._telephone1;
		}
		set
		{
			if (((_telephone1 == value) 
						== false))
			{
				this.OnTelephone1Changing(value);
				this.SendPropertyChanging();
				this._telephone1 = value;
				this.SendPropertyChanged("Telephone1");
				this.OnTelephone1Changed();
			}
		}
	}
	
	[Column(Storage="_telephone2", Name="telephone_2", DbType="varchar(20)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Telephone2
	{
		get
		{
			return this._telephone2;
		}
		set
		{
			if (((_telephone2 == value) 
						== false))
			{
				this.OnTelephone2Changing(value);
				this.SendPropertyChanging();
				this._telephone2 = value;
				this.SendPropertyChanged("Telephone2");
				this.OnTelephone2Changed();
			}
		}
	}
	
	[Column(Storage="_userName", Name="username", DbType="varchar(15)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string UserName
	{
		get
		{
			return this._userName;
		}
		set
		{
			if (((_userName == value) 
						== false))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._userName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_tbLCc", OtherKey="ID", ThisKey="IDCcType", Name="fk_tbl_users_0", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public TBlCc TBlCc
	{
		get
		{
			return this._tbLCc.Entity;
		}
		set
		{
			if (((this._tbLCc.Entity == value) 
						== false))
			{
				if ((this._tbLCc.Entity != null))
				{
					TBlCc previousTBlCc = this._tbLCc.Entity;
					this._tbLCc.Entity = null;
					previousTBlCc.TBlUsers.Remove(this);
				}
				this._tbLCc.Entity = value;
				if ((value != null))
				{
					value.TBlUsers.Add(this);
					_idcCType = value.ID;
				}
				else
				{
					_idcCType = null;
				}
			}
		}
	}
	
	[Association(Storage="_tbLPayment", OtherKey="ID", ThisKey="IDPayment", Name="fk_tbl_users_1", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public TBlPayment TBlPayment
	{
		get
		{
			return this._tbLPayment.Entity;
		}
		set
		{
			if (((this._tbLPayment.Entity == value) 
						== false))
			{
				if ((this._tbLPayment.Entity != null))
				{
					TBlPayment previousTBlPayment = this._tbLPayment.Entity;
					this._tbLPayment.Entity = null;
					previousTBlPayment.TBlUsers.Remove(this);
				}
				this._tbLPayment.Entity = value;
				if ((value != null))
				{
					value.TBlUsers.Add(this);
					_idpAyment = value.ID;
				}
				else
				{
					_idpAyment = null;
				}
			}
		}
	}
	
	[Association(Storage="_tbLRoles", OtherKey="ID", ThisKey="IDRole", Name="fk_tbl_users_2", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public TBlRoles TBlRoles
	{
		get
		{
			return this._tbLRoles.Entity;
		}
		set
		{
			if (((this._tbLRoles.Entity == value) 
						== false))
			{
				if ((this._tbLRoles.Entity != null))
				{
					TBlRoles previousTBlRoles = this._tbLRoles.Entity;
					this._tbLRoles.Entity = null;
					previousTBlRoles.TBlUsers.Remove(this);
				}
				this._tbLRoles.Entity = value;
				if ((value != null))
				{
					value.TBlUsers.Add(this);
					_idrOle = value.ID;
				}
				else
				{
					_idrOle = null;
				}
			}
		}
	}
	
	[Association(Storage="_reLoPeratorsCustomers", OtherKey="IDOperator", ThisKey="ID", Name="fk_tbl_users_3", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public ReLOperatorsCustomers ReLOperatorsCustomers
	{
		get
		{
			return this._reLoPeratorsCustomers.Entity;
		}
		set
		{
			if (((this._reLoPeratorsCustomers.Entity == value) 
						== false))
			{
				if ((this._reLoPeratorsCustomers.Entity != null))
				{
					ReLOperatorsCustomers previousReLOperatorsCustomers = this._reLoPeratorsCustomers.Entity;
					this._reLoPeratorsCustomers.Entity = null;
					previousReLOperatorsCustomers.TBlUsers.Remove(this);
				}
				this._reLoPeratorsCustomers.Entity = value;
				if ((value != null))
				{
					value.TBlUsers.Add(this);
					_id = value.IDOperator;
				}
				else
				{
					_id = default(int);
				}
			}
		}
	}
	#endregion
	
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
