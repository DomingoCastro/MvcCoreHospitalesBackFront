﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MvcCoreHospitalesBackFront.Models
{
    
    public class Hospital
    {
        public int IdHospital { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Camas { get; set; }
    }
}