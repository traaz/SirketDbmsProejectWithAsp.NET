﻿using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICalisanDal:IEntityRepository<Calisan>
    {
        EgitimDurumuCovidDto GetLisanssizCovid();
        EgitimDurumuCovidDto GetLisansCovid();
        EgitimDurumuCovidDto GetYuksekLisansCovid();
        EgitimDurumuCovidDto GetDoktoraCovid();
       
      
        
    }
}
