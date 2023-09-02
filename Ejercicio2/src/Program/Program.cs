/* using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
} */


using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un paciente
            var patient = new Patient("Steven Jhonson", "986782342", "5555-555-555");

            // Crear un médico
            var doctor = new Doctor("Armand", "Cardiology");

            // Crear una cita
            var appointment = new Appointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");

            // Crear una cita con datos que faltan
            var invalidAppointment = new Appointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");

            // Program.cs no realiza validación, pero se realiza en la clase AppointmentService
            string appointmentResult = AppointmentService.CreateAppointment(appointment);
            Console.WriteLine(appointmentResult);

            string invalidAppointmentResult = AppointmentService.CreateAppointment(invalidAppointment);
            Console.WriteLine(invalidAppointmentResult);
        }
    }
}
