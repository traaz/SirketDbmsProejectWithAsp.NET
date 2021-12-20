﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCovidDal : EfEntityRepositoryBase<Covid, SirketDBContext>, ICovidDal
    {
        public List<BiontechDto> GetBiontech()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from covid in context.Covids
                             join asi in context.Asilar on covid.CovidId equals asi.CovidId
                             join calisan in context.Calisanlar on covid.CalisanId equals calisan.CalisanId
                             join hastalik in context.Hastaliklar on calisan.CalisanId equals hastalik.CalisanId
                             where asi.AsiIsmi == "Biontech"
                             select new BiontechDto
                             {
                                 TcNo = calisan.TcNo,
                                 Isim = calisan.Isim,
                                 Soyisim = calisan.Soyisim,
                                 CovidYakalanmaTarih = covid.CovidYakalanmaTarih,
                                 CovidBitisTarih = covid.CovidBitisTarih,
                                 AsiIsmi = asi.AsiIsmi,
                                 HastalikIsmi = hastalik.HastalikIsmi

                             };
                return result.ToList();

            }
        }
    }
}
