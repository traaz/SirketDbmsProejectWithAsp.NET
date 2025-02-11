﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAsiDal : EfEntityRepositoryBase<Asi, SirketDBContext>, IAsiDal
    {
 
        public List<BiontechSinovacCovidDto> GetBiontechSinovacCovidDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from asi in context.Asilar
                             join covid in context.Covids
                             on asi.CovidId equals covid.CovidId
                             group covid by asi.AsiIsmi into isim
                             select new BiontechSinovacCovidDto
                             {
                                 
                                 AsiIsmi=isim.Key,
                                 OrtalamaCovidSuresi = isim.Average(x => EF.Functions.DateDiffDay(x.CovidYakalanmaTarih, x.CovidBitisTarih))

                             };
                return result.ToList();


            }
        }
    }
}
