﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Calisan:IEntity
    {
        public int CalisanId { get; set; }
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string KanGrubu { get; set; }
        public string DogumSehir { get; set; }
        public string IsPozisyonu { get; set; }
        public int Maas { get; set; }
        public int Lisans { get; set; }
        public int YuksekLisans { get; set; }
        public int Doktora { get; set; }

        
    }
}
