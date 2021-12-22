﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Mesai:IEntity
    {
        public int MesaiId { get; set; }
        public int CalisanId { get; set; }

        public string GunAdi { get; set; }
        public  TimeSpan IsBaslangicSaati { get; set; }
        public TimeSpan IsBitisSaati { get; set; }


    }
}
