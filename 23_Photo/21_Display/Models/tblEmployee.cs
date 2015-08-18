using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace _21_Display.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class tblEmployee 
    {
    }

    public class EmployeeMetaData 
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        // Generate a hyperlink
        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }
        // Display currency symbol. For country specific currency, set 
        // culture using globalization element in web.config. 
        // For Great Britain Pound symbol
        // <globalization culture="en-gb"/>
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }
        // Display mailto hyperlink
        [DataType(DataType.EmailAddress)]
        [ReadOnly(true)]
        public string EmailAddress { get; set; }
        //[DisplayAttribute(Name="Full Name")]
        //[Display(Name = "Full Name")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        //To get only the date part in a datetime data type
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //[DisplayFormatAttribute(DataFormatString="{0:d}")]

        //To get time in 24 hour notation
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        /*To get time in 12 hour notation with AM PM
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? HireDate { get; set; }*/

        // Display only Time Part
        // [DataType(DataType.Time)]
        // Display only Date Part
       // [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? HireDate { get; set; }

        // If gender is NULL, "Gender not specified" text will be displayed.
        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }

        //If you don't want to display a column use ScaffoldColumn attribute.
        /*This only works when you use @Html.DisplayForModel() helper
        [ScaffoldColumn(false)]
        public int? Salary { get; set; }*/

    }
}