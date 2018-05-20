using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDS.Models;


namespace BDS.Controllers
{
    public class HomeController : Controller
    {
        //Declare database
        Database data = new Database();

        public ActionResult Index()
        {
            return View();
        }

        //
        public ActionResult Product()
        {
            var listHouse = data.Houses.Where(house => house.Deleted != true).Take(9).ToList();
            return View(listHouse);
        }
        
        //
        public ActionResult ProductDetail(int houseId = 0)
        {
            House houseDetails = data.Houses.FirstOrDefault(house => house.HouseId == houseId && house.Deleted != true);
            if (houseDetails == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(houseDetails);
        }
        // Footer Index New house and Famous house
        public PartialViewResult NewHousePartial()
        {
            var listNewHouse = data.Houses.Take(4).ToList();
            return PartialView(listNewHouse);
        }

        // Footer advert
        public PartialViewResult AdvertPartial()
        {
            return PartialView();
        }

       
    }

}