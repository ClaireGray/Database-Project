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
    public class LeaseDetail
    {
        public int leaseID { set; get; }
        public short numOfSemester { set; get; }
        public DateTime moveInDate { set; get; }
        public DateTime moveOutDate { set; get; }
        public int placeID { set; get; }
        public int bannerNumber { set; get; }
    }
}