//using APBD_TEMPLATE.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_TEMPLATE.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    /*
    public DbSet<Appointment> Appointments { get; set; } = null!;
    public DbSet<AppointmentService> AppointmentServices { get; set; } = null!;
    public DbSet<Doctor> Doctors { get; set; } = null!;
    public DbSet<MedicalService> MedicalServices { get; set; } = null!;
    public DbSet<Patient> Patients { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<AppointmentService>()
            .HasKey(a => new { a.AppointmentId, a.ServiceId });

        var appointments = new[]
        {
            new Appointment
            {
                AppointmentId = 1,
                PatientId = 1,
                DoctorId = 1,
                AppointmentDate = DateOnly.FromDateTime(DateTime.Now),
                Status = "Finished"
            }
        };
        
        var doctors = new[]
        {
            new Doctor
            {
                DoctorId = 1,
                FirstName = "John",
                LastName = "Doe",
                Specialization = "Dentist",
                Phone = "111111111"
            }
        };

        var patients = new[]
        {
            new Patient
            {
                PatientId = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Today,
                Phone = "111111111"
            }
        };

        var appointmentServices = new[]
        {
            new AppointmentService
            {
                AppointmentId = 1,
                ServiceId = 1,
                Quantity = 1,
                PerformedAt = DateOnly.FromDateTime(DateTime.Now),
            }
        };

        var medicalServices = new[]
        {
            new MedicalService
            {
                ServiceId = 1,
                Name = "Medical",
                Description = "Medical",
                Price = 1000,
                DurationMinutes = 45
            }
        };
        
        modelBuilder.Entity<Appointment>().HasData(appointments);
        modelBuilder.Entity<Doctor>().HasData(doctors);
        modelBuilder.Entity<Patient>().HasData(patients);
        modelBuilder.Entity<AppointmentService>().HasData(appointmentServices);
        modelBuilder.Entity<MedicalService>().HasData(medicalServices);
    }
    */
}