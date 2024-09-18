using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeBankingSystem.Models
{
    public class Office
    {
        public string Office_name { get; set; }
        public string Office_Code { get; set; }
        public string Authorize_user { get; set; }
        public string Email { get; set; }
        public int Contact_Officer { get; set; }
        public int Investor { get; set; }
        public string Address { get; set; }
        public int Postal_Code { get; set; }
        public int Division { get; set; }
        public int Distric { get; set; }
        public int Upozila { get; set; }
        public int Unio_n { get; set; }
        public string Thana { get; set; }
        public string Village { get; set; }
        public string Road { get; set; }
        public string Ward_No { get; set; }
        public DateTime Office_StartDate { get; set; }
    }
}