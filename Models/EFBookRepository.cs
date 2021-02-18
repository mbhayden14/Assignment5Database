using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;
        
        //Constructor
        public EFBookRepository (BookDBContext context)
        {
            _context = context;
        }

        public IQueryable<Project> Projects => _context.Projects;
    }
}
