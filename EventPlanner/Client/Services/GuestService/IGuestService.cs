using EventPlanner.Dto;

namespace EventPlanner.Client.Services.GuestService
{
    public interface IGuestService
    {
        public Task<List<Guest>> GetGuestListByEventId(Guid id);
        public Task<Guest> GetGuestById();
        public Task<Guest> CreateGuest(Guest guest);
        public Task<Guest> UpdateGuest(Guest guest);

    }
}
