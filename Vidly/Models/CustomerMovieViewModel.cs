using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class CustomerMovieViewModel
    {
        public List<MovieModel> Movie { get; set; }
        public List<CustomerModel> Customers { get; set; }
    }
}