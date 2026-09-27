// Data/AppDbContext.cs

using Microsoft.EntityFrameworkCore;
using FlowVerify.Api.Entities;

namespace FlowVerify.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    //public