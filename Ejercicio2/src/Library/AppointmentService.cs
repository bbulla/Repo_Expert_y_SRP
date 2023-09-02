/* using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            // Empieza la validación de los datos de la cita.
            // Esta lógica podría ser manejada por una clase separada.

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled");
            }

            // El método actual realiza tanto la validación como la generación de mensajes,
            // lo que viola el principio SRP. Se podría dividir estas responsabilidades.

            return stringBuilder.ToString();
        }
    }
}
 */

using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (appointment.Validate())
            {
                stringBuilder.Append("Appointment scheduled");
            }

            return stringBuilder.ToString();
        }
    }
}
