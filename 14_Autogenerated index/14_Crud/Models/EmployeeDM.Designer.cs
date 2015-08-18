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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MVCModel", "FK__tblEmploy__Depar__0519C6AF", "tblDepartment", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(_14_Crud.Models.Department), "tblEmployee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(_14_Crud.Models.Employee), true)]

#endregion

namespace _14_Crud.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MVCcontext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MVCcontext object using the connection string found in the 'MVCcontext' section of the application configuration file.
        /// </summary>
        public MVCcontext() : base("name=MVCcontext", "MVCcontext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MVCcontext object.
        /// </summary>
        public MVCcontext(string connectionString) : base(connectionString, "MVCcontext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MVCcontext object.
        /// </summary>
        public MVCcontext(EntityConnection connection) : base(connection, "MVCcontext")
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
        public ObjectSet<Department> tblDepartment
        {
            get
            {
                if ((_tblDepartment == null))
                {
                    _tblDepartment = base.CreateObjectSet<Department>("tblDepartment");
                }
                return _tblDepartment;
            }
        }
        private ObjectSet<Department> _tblDepartment;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> tblEmployee
        {
            get
            {
                if ((_tblEmployee == null))
                {
                    _tblEmployee = base.CreateObjectSet<Employee>("tblEmployee");
                }
                return _tblEmployee;
            }
        }
        private ObjectSet<Employee> _tblEmployee;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblDepartment EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblDepartment(Department department)
        {
            base.AddObject("tblDepartment", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblEmployee EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblEmployee(Employee employee)
        {
            base.AddObject("tblEmployee", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MVCModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Department CreateDepartment(global::System.Int32 id)
        {
            Department department = new Department();
            department.Id = id;
            return department;
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
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MVCModel", "FK__tblEmploy__Depar__0519C6AF", "tblEmployee")]
        public EntityCollection<Employee> Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblEmployee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblEmployee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MVCModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeId">Initial value of the EmployeeId property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeId)
        {
            Employee employee = new Employee();
            employee.EmployeeId = employeeId;
            return employee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeId
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                if (_EmployeeId != value)
                {
                    OnEmployeeIdChanging(value);
                    ReportPropertyChanging("EmployeeId");
                    _EmployeeId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeId");
                    OnEmployeeIdChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeId;
        partial void OnEmployeeIdChanging(global::System.Int32 value);
        partial void OnEmployeeIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
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
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                OnDepartmentIdChanging(value);
                ReportPropertyChanging("DepartmentId");
                _DepartmentId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DepartmentId");
                OnDepartmentIdChanged();
            }
        }
        private Nullable<global::System.Int32> _DepartmentId;
        partial void OnDepartmentIdChanging(Nullable<global::System.Int32> value);
        partial void OnDepartmentIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MVCModel", "FK__tblEmploy__Depar__0519C6AF", "tblDepartment")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblDepartment").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblDepartment").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblDepartment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("MVCModel.FK__tblEmploy__Depar__0519C6AF", "tblDepartment", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
