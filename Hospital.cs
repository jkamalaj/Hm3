using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class Hospital
    {
       public  List<Appointment> appointments =new List<Appointment>();

        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        public void EndAppointment(string no)
        {
            appointments.Find(x => x.No == no).EndDate = DateTime.Now;
        }

        public void GetAppointment(string no)
        {
            appointments.Find(x => x.No == no);
            
              
        }
        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }
        public List<Appointment> GetWeeklyAppointments()
        {
            return appointments.FindAll(x => x.StartDate < DateTime.Now && x.StartDate > DateTime.Now.Date.AddDays(-7));
        }
        public List<Appointment> GetTodaysAppointments()
        {
            return appointments.FindAll(x => x.StartDate.ToShortDateString() == DateTime.Now.ToShortDateString());
        }
        public List<Appointment> GetAllContinuingAppointment()
        {
            return appointments.FindAll(x => x.EndDate.Year == 0001);
        }

        public void GenerateAppointmet(Hospital hospital)
        {
            Console.WriteLine("1.Patientinin adini ve soyadini daxil edin:");
            string patient = Console.ReadLine();
            Console.WriteLine("2.Doctorun adini ve soyadini daxil edin:");
            string doctor = Console.ReadLine();
            
            string startdatestr;
            DateTime startDate;
            do
            {
                Console.WriteLine("3.StartDate daxil edin:");
                startdatestr = Console.ReadLine();
            }while(!DateTime.TryParse(startdatestr, out startDate));
            Console.WriteLine("4.EndDate daxil edin:");
            string enddatestr;
            DateTime endDate;
            do
            {
                Console.WriteLine("4.EndDate daxil edin:");
                enddatestr = Console.ReadLine();
            }while(DateTime.TryParse(enddatestr, out endDate));


            Appointment appointment = new Appointment();
            {
                appointment.Patient = patient;
                appointment.Doctor = doctor;
                appointment.StartDate = startDate;
                appointment.EndDate = endDate;


            };
            hospital.AddAppointment(appointment);

        }




    }
}
