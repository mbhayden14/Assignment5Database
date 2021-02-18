using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public interface IBookRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
