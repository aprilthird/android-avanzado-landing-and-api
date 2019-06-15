using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.DATA.Context
{
    public class FdneContextFactory : IDesignTimeDbContextFactory<FdneContext>
    {
        public FdneContextFactory() { }

        public FdneContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FdneContext>();

            builder.UseSqlServer(
                "Server=localhost;Database=FDNEDB378;Trusted_Connection=True;MultipleActiveResultSets=true"
                //DataConnectionString
                , opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));

            return new FdneContext(builder.Options);
        }
    }
}
