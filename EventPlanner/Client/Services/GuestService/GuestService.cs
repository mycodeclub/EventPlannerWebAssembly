using EventPlanner.Dto;
using System.Net.Http.Json;

namespace EventPlanner.Client.Services.GuestService
{
    public class GuestService : IGuestService
    {
        public HttpClient _httpClient { get; }
        public GuestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Guest> Guests { get; set; } = new List<Guest>();

        public Task<Guest> CreateGuest(Guest guest)
        {
            throw new NotImplementedException();
        }

        public Task<Guest> GetGuestById()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Guest>> GetGuestListByEventId(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Guest>>($"/api/Guest/{id}");
            return result;
        }

        public Task<Guest> UpdateGuest(Guest guest)
        {
            throw new NotImplementedException();
        }
    }
}
