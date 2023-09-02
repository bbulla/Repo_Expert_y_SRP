using System;

namespace Library
{
    public class Appointment
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentPlace { get; set; }
        public string DoctorName { get; set; }

        public Appointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
            Date = date;
            AppointmentPlace = appointmentPlace;
            DoctorName = doctorName;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(AppointmentPlace) || string.IsNullOrEmpty(DoctorName))
            {
                Console.WriteLine("Error: All fields (Name, ID, Phone number, Appointment place, and Doctor name) are required.");
                return false;
            }

            return true;
        }
    }
}
