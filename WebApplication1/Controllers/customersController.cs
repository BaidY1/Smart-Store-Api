using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class customersController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/customers

        [HttpGet]
        [Route("/Login/{username}/{password}")]
        public string Login(string username, string password)
        {
            var cust = db.customers.Find(username, password);
            if (cust != null)
            {
                return "Customer Logged In";
            }
            else
            {
                return "Not Found";

            }
        }


        [HttpPost]
        [Route("/Login/{username}/{password}")]
        public string SaveCustomer(customer customer)
        {
            try
            {
                db.customers.Add(customer);

                return "Customer Saved";
            } catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

    }
      
}