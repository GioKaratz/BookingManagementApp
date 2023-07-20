using BookingManagementApp.Contracts;
using BookingManagementApp.Data;
using BookingManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingManagementApp.Repository
{
    public class BookingRepository : IBookingReposiroty
    {
        private readonly ApplicationDbContext _context;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Booking booking)
        {
            _context.Add(booking);
            return Save();
        }

        public bool Delete(Booking booking)
        {
            _context.Remove(booking);
            return Save();
        }

        public async Task<IEnumerable<Booking>> GetAllAsyng()
        {
            return await _context.Booking.ToListAsync();
        }

        public async Task<Booking?> GetByIdAsync(int id)
        {
            return await _context.Booking.FirstOrDefaultAsync(c => c.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Booking booking)
        {
            _context.Update(booking);
            return Save();
        }
    }
}
