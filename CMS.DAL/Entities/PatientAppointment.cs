using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Entities
{
    public class PatientAppointment
    {
        [Key]
        public int Id { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime Add_time { get; set; }
        public  int Add_By { get; set;}

        public int DoctorId { get; set;}
        public Doctor Doctor { get; set;}

    }
}
