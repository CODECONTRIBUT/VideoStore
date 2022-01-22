using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.ViewModel
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}