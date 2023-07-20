using System.ComponentModel.DataAnnotations;

namespace BookingManagementApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FamilyMembers { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int VisitDays { get; set; }
    }
}
