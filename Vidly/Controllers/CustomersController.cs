using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult GetCustomers()
        {
            var movie = new List<MovieModel>() { new MovieModel { MovieName = "Shrek 1" } };

            var customers = new List<CustomerModel> { 
                
                new CustomerModel { CustId = 101, CustName = "Thomas"},
                new CustomerModel { CustId = 102, CustName = "Stephen"},
            };

            var viewModel = new CustomerMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }


        [Route ("customers/customerdetails/{custid}")]
        public ActionResult CustomerDetails(int custid)
        {
            var customers = new List<CustomerModel> {

                new CustomerModel { CustId = 101, CustName = "Thomas"},
                new CustomerModel { CustId = 102, CustName = "Stephen"},
            };

            var singleCustomer = new CustomerModel();
            foreach(var cust in customers)
            {
                if(cust.CustId == custid)
                {
                    singleCustomer.CustId = cust.CustId;
                    singleCustomer.CustName = cust.CustName;
                }
            }
            

            return View(singleCustomer);
        }
    }
}