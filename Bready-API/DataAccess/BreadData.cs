using System;
using System.Collections.Generic;
using BreadyAPI.DbContexts;
using BreadyAPI.Models;
using System.Linq;

namespace BreadyAPI.DataAccess
{
    public class BreadData
    {
        private readonly BreadDbContext _context;

        public BreadData(BreadDbContext context)
        {
            _context = context;
        }

        public List<Bread> GetBreads()
        {
            var breadEntities = _context.Breads;
            return breadEntities.Select(breadEntity => new Bread(breadEntity)).ToList();
        }
    }
}
