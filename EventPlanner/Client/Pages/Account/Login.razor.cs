using EventPlanner.Dto.User;
using EventPlanner.Dto;
using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;

namespace EventPlanner.Web.Pages
{
    public partial class Login
    {



        public static LoginVM logInRequest { get; set; } = new();

        public static LoginResponse _response { get; set; }
        [Inject]
        protected NavigationManager NavigationManager { get; set; }
        [Inject]
        protected ILocalStorageService _localStorage { get; set; }

        public async void SubmitLoginRequest()
        {
//            var result = accountService.Login(logInRequest);
            //_response = result.Result;
            //if (_response.IsLoginSuccess)
            //{
            //    var tokenStr = _response.Token;
            //    _localStorage.SetItemAsync("jwt_token", tokenStr);
            //    _localStorage.SetItemAsync("EpOrgId", _response.EpOrgId);
            //    NavigationManager.NavigateTo("/EventOrganizer/Dashboard");
            //}
            //else
                Console.WriteLine("Some thing went wrong, " + string.Join(", ", _response.ErrorMessages));
            var token = _response.Token;
        }

    }
}
