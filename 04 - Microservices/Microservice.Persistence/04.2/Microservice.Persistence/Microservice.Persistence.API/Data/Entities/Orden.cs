﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservice.Persistence.API.Data.Entities
{
    public partial class Orden
    {
        public Orden()
        {
            OrdenItems = new HashSet<OrdenItem>();
        }

        public int OrdenId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<OrdenItem> OrdenItems { get; set; }
    }
}