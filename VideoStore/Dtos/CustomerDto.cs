using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the customer's name.")]
        [MaxLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        [Required(ErrorMessage = "Please choose a Memebership type.")]
        public Byte MemberShipTypeId { get; set; }

     //   [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}