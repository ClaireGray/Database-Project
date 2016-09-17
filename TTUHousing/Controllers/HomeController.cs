//Claire Gray & Kelsey Gonzales
//CS4354 
//Homework 5
//May 13, 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTUHousing.Models;
using TTUHousing.ViewModels;

namespace TTUHousing.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Display the total number of student for each category
        /// </summary>
        /// <returns></returns>
        public ActionResult Query9()
        {
            var levelGroups = db.Students
                .GroupBy(s => s.StudentLevel.levelName)
                .Select(sg => new StudentGroup()
                {
                    levelName = sg.Key,
                    studentCount = sg.Count()
                });

            return View(levelGroups);
        }

        //Display the Staff detail who are over 60 years old.

        public ActionResult Query14()
        {
            var result = db.Staff
                .Where(a => (DateTime.Now.Year - a.dateOfBirth.Value.Year) > 60)
                .Select(
                    a => new OldStaff
                    {
                        StaffNumber = a.staffNo,
                        Age = DateTime.Now.Year - a.dateOfBirth.Value.Year,
                        Name = a.lastName + ", " + a.firstName,
                        Location = a.street + ", " + a.city + ", " + a.postalCode
                    }
                );
            return View(result);
        }

        //Display the total number of registered vehicle in a particular parking lot.
        public ActionResult Query15()
        {
            var totalVehicle = db.Vehicles
                .GroupBy(b => b.Parking.parkingID)
                .Select(ab => new VehicleGroup()
                {
                    parkingID = ab.Key,
                    vehicleCount = ab.Count()

                });
            return View(totalVehicle);
        }

        //Display the details of apartment inspection where the property was found to be in an unsatisfactory condition
        public ActionResult Query6()
        {
            var InspectionDetail = db.Inspections
                .Where(a => (a.satisfactory) == "Fail")
                .Select(
                    a => new InspectionData
                    {
                        inspectionNo = a.inspectionNo,
                        inspectionDate = a.inspectionDate,
                        satisfactory = a.satisfactory,
                        comments = a.comments,
                        flatNo = a.flatNo,
                        staffNo = a.staffNo
                    });
            return View(InspectionDetail);
        }

        //Display the details of the lease agreements.
        public ActionResult Query3()
        {
            var leasedata = db.Leases
                .Select(
                    l => new LeaseDetail
                    {
                        leaseID = l.leaseID,
                        numOfSemester = l.numOfSemester.Value,
                        moveInDate = l.moveInDate.Value,
                        moveOutDate = l.moveOutDate.Value,
                        placeID = l.placeID,
                        bannerNumber = l.bannerNumber
    
                    }
                );

            return View(leasedata);
        }

    }
}