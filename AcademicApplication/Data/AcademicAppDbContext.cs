using AcademicApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Data
{
    public class AcademicAppDbContext: IdentityDbContext<AppUser, AppRole, string>
    {

        public AcademicAppDbContext()
        {

        }

        public AcademicAppDbContext(DbContextOptions<AcademicAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<Course> courses { get; set; }

        public DbSet<Subject> subjects { get; set; }

        public DbSet<Topic> topics { get; set; }

        public DbSet<CourseCart> courseCarts { get; set; }

        public DbSet<CourseImages> CourseImages { get; set; }

        public DbSet<SalesTarget> salesTargets { get; set; }

        public DbSet<PaidCourses>  PaidCourses { get; set; }

        public DbSet<CourseSubscribe> courseSubscribes  { get; set; }
    }
}
