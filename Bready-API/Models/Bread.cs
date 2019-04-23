using System;
using BreadyAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BreadyAPI.Models
{
    public class Bread
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Bread(BreadEntity breadEntity)
        {
            Id = breadEntity.Id;
            Name = breadEntity.Name;
        }
    }
}
