using Microsoft.EntityFrameworkCore;
using JobPortalApplicantTracking.Models;

namespace JobPortalApplicantTracking.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
}
