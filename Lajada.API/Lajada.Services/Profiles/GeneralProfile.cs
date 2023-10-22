using AutoMapper;
using Lajada.Domain.Entities;
using Lajada.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Services.Profiles
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile() 
        { 
            CreateMap<Personal_Information, Personal_InformationDto>().ReverseMap();
        }
    }
}
