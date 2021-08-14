﻿using AutoMapper;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaProfile : Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();





        }
    }
}
