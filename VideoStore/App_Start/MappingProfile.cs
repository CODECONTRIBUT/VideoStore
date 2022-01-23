using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoStore.Dtos;
using VideoStore.Models;

namespace VideoStore.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // ignore Id property Auto-Mapping, because Id is primary key in DB.
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}