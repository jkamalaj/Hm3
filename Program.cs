using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp15
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("az-AZ");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

             Hospital hospital = new Hospital();

            string answer;
            do
            {
                Console.WriteLine("1.Appointment yarat.");
                Console.WriteLine("2.Appointmenti bitir.");
                Console.WriteLine("3.Butun appointmentlere bax.");
                Console.WriteLine("4.Bu hefteki appointmentlere bax.");
                Console.WriteLine("5.Bugunki appointmetnlere bax.");
                Console.WriteLine("6.Davam eden appointmetnlere bax.");
                Console.WriteLine("7.Menudan cix.");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        hospital.GenerateAppointmet(hospital);
                        
                        break;
                    case "2":
                        Console.WriteLine("No daxil edin:");
                        string nostr = Console.ReadLine();
                        hospital.EndAppointment(nostr);
                        break;
                    case "3":
                        hospital.GetAllAppointments();
                        break;
                    case "4":
                        hospital.GetWeeklyAppointments();
                        break;
                    case "5":
                        hospital.GetTodaysAppointments();
                        break;
                    case "6":
                        hospital.GetAllContinuingAppointment();
                        break;
                    case "7":

                        break;
                }
                   
            } while (answer!="1" && answer!="2" && answer!="3" && answer!="4" && answer!="5" && answer!="6" && answer!="7");
        }
        


    }
}
