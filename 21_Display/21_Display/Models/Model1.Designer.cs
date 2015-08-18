﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace _21_Display.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SampleContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SampleContext object using the connection string found in the 'SampleContext' section of the application configuration file.
        /// </summary>
        public SampleContext() : base("name=SampleContext", "SampleContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SampleContext object.
        /// </summary>
        public SampleContext(string connectionString) : base(connectionString, "SampleContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SampleContext object.
        /// </summary>
        public SampleContext(EntityConnection connection) : base(connection, "SampleContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tblEmployee> tblEmployee
        {
            get
            {
                if ((_tblEmployee == null))
                {
                    _tblEmployee = base.CreateObjectSet<tblEmployee>("tblEmployee");
                }
                return _tblEmployee;
            }
        }
        private ObjectSet<tblEmployee> _tblEmployee;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblEmployee EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblEmployee(tblEmployee tblEmployee)
        {
            base.AddObject("tblEmployee", tblEmployee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="displayModel", Name="tblEmployee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblEmployee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tblEmployee object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static tblEmployee CreatetblEmployee(global::System.Int32 id)
        {
            tblEmployee tblEmployee = new tblEmployee();
            tblEmployee.Id = id;
            return tblEmployee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                OnFullNameChanging(value);
                ReportPropertyChanging("FullName");
                _FullName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FullName");
                OnFullNameChanged();
            }
        }
        private global::System.String _FullName;
        partial void OnFullNameChanging(global::System.String value);
        partial void OnFullNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                OnHireDateChanging(value);
                ReportPropertyChanging("HireDate");
                _HireDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HireDate");
                OnHireDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private Nullable<global::System.Int32> _Salary;
        partial void OnSalaryChanging(Nullable<global::System.Int32> value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PersonalWebSite
        {
            get
            {
                return _PersonalWebSite;
            }
            set
            {
                OnPersonalWebSiteChanging(value);
                ReportPropertyChanging("PersonalWebSite");
                _PersonalWebSite = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PersonalWebSite");
                OnPersonalWebSiteChanged();
            }
        }
        private global::System.String _PersonalWebSite;
        partial void OnPersonalWebSiteChanging(global::System.String value);
        partial void OnPersonalWebSiteChanged();

        #endregion

    
    }

    #endregion

    
}
