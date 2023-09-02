using System;

namespace Library
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Doctor(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Specialization))
            {
                Console.WriteLine("Error: Both 'Name' and 'Specialization' are required.");
                return false;
            }

            return true;
        }
    }
}
