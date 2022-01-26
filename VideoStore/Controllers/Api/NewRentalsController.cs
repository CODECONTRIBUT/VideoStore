using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoStore.Dtos;
using VideoStore.Models;

namespace VideoStore.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movies are choosen.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            if (customer == null)
                return BadRequest("This customer does not exist.");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more movies are not available.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie" + movie.Name + " is not available. Please check out the inventory");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

                
            }
            _context.SaveChanges();

            return Ok();    
        }
    }
}
