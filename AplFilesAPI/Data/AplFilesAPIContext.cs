using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AplFilesAPI.Models;

#nullable disable

namespace AplFilesAPI.Data
{
    public partial class AplFilesAPIContext : DbContext
    {
        public AplFilesAPIContext()
        {
        }

        public AplFilesAPIContext(DbContextOptions<AplFilesAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
