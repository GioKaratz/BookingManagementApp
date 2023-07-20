using AutoMapper;
using BookingManagementApp.Contracts;
using BookingManagementApp.Data;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingReposiroty _repo;
        private readonly IMapper _mapper;

        public BookingController(IBookingReposiroty repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var booking = await _repo.GetAllAsyng();
            var data = _mapper.Map<IEnumerable<Booking>>(booking);
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            Booking booking = await _repo.GetByIdAsync(id);
            return View(booking);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Booking booking)
        {
            if(!ModelState.IsValid)
            {
                return View(booking);
            }
            _repo.Add(booking);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var booking = await _repo.GetByIdAsync(id);
            if (booking == null)
                return View("Error");
            return View(booking);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Booking booking)
        {
            if (!ModelState.IsValid)
            {
                return View(booking);
            }
            _repo.Update(booking);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bookingDetails = await _repo.GetByIdAsync(id);
            if (bookingDetails == null)
                return View("Error");
            return View(bookingDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _repo.GetByIdAsync(id);
            _repo.Delete(booking);
            return RedirectToAction("Index");
        }
    }
}
