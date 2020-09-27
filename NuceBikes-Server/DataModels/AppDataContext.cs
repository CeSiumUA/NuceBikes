using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options)
        {

        }
    }
}
