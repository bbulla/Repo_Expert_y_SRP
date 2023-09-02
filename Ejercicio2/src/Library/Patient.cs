using System;

namespace Library
{
    public class Patient
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }

        public Patient(string name, string id, string phoneNumber)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(PhoneNumber))
            {
                Console.WriteLine("Error: All fields (Name, ID, and Phone number) are required.");
                return false;
            }

            return true;
        }
    }
}
