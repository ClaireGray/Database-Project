namespace TTUHousing.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Advisor> Advisors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Flat> Flats { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Inspection> Inspections { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Lease> Leases { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<NextOfKin> NextOfKins { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAttendCourse> StudentAttendCourses { get; set; }
        public virtual DbSet<StudentLevel> StudentLevels { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advisor>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Advisor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.courseName)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.deptName)
                .IsUnicode(false);

            modelBuilder.Entity<Flat>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Flat>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Flat>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Flat>()
                .HasMany(e => e.Inspections)
                .WithRequired(e => e.Flat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flat>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Flat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.hallName)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspection>()
                .Property(e => e.satisfactory)
                .IsUnicode(false);

            modelBuilder.Entity<Inspection>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.semester)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.payDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.payMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Lease>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Lease)
                .HasForeignKey(e => e.leaseNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.majorName)
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Major)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.relationship)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NextOfKin>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.NextOfKin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parking>()
                .HasMany(e => e.Vehicles)
                .WithRequired(e => e.Parking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.positionName)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.rentRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Room>()
                .Property(e => e.payMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Leases)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Halls)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Inspections)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.specialNeeds)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Leases)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.semester)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.instructor)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.roomNo)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .Property(e => e.deptName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendCourse>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.StudentAttendCourse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentLevel>()
                .Property(e => e.levelName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentLevel>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.StudentLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);
        }
    }
}
