//Claire Gray & Kelsey Gonzales
//CS4354 
//Homework 5
//May 13, 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTUHousing.ViewModels
{
    public class InspectionData
    { 
        public int inspectionNo { set; get; }
        public DateTime inspectionDate { set; get; }
        public string satisfactory { set; get; }
        public string comments { set; get; }
        public int flatNo { set; get; }
        public int staffNo { set; get; }
    }
}