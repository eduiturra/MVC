﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _20_HelperListBox.Models
{
    public class CitiesViewModel
    {
        public IEnumerable<string> SelectedCities { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}