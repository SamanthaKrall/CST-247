using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerModel = Activity2Part1.Models.CustomerModel;
using static System.Tuple;

namespace Activity2Part1.Controllers
{
    public class CustomerController : Controller
    {
        private List<CustomerModel> customer { get; set; }

        public CustomerController()
        {
            CustomerModel cust1 = new CustomerModel(1, "Samantha Krall", 36);
            CustomerModel cust2 = new CustomerModel(2, "Steven Krall", 27);

            customer = new List<CustomerModel>();

            customer.Add(cust1);
            customer.Add(cust2);
        }

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> 
                tuple = new 
                Tuple<List<CustomerModel>, 
                CustomerModel>(customer, customer[0]);

            return View(tuple);
        }

        [HttpPost]
        public PartialViewResult OnSelectCustomer(string Item1)
        {
            int id = Int32.Parse(Item1);
            CustomerModel cust = customer.Where(i => i.ID == id).First();
            Tuple<List<CustomerModel>, CustomerModel>
                tuple = new 
                Tuple<List<CustomerModel>, CustomerModel>(this.customer, cust);
            return PartialView("_CustomerDetails", tuple.Item2);
        }

        [HttpPost]
        public string GetMoreInfo(string customer)
        {
            return customer + " Success!";
        }
    }
}