using BookingManagementApp.Models;

namespace BookingManagementApp.Contracts
{
    public interface IBookingReposiroty
    {
        Task<IEnumerable<Booking>> GetAllAsyng();
        Task<Booking?> GetByIdAsync(int id);
        bool Add(Booking booking);
        bool Update(Booking booking);
        bool Delete(Booking booking);
        bool Save();
    }
}
