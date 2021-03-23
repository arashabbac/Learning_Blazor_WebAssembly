using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Net.Http.Json;

namespace Client.Services
{
    public class UserService : Infrastructure.BaseService
    {
        private readonly NavigationManager _navigationManager;

        public UserService(System.Net.Http.HttpClient client,
        NavigationManager navigationManager) : base(client)
		{
            _navigationManager = navigationManager;
		}

		protected override string GetApiUrl()
		{
			return "users";
		}

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ViewModels.User.UserViewModel>>
            GetAllAsync()
        {
            RequestUri = $"{ BaseUrl }/{ GetApiUrl() }/getAllUsers";

            var result = await GetAsync<System.Collections.Generic.List<ViewModels.User.UserViewModel>>();

            return result; 
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<ViewModels.User.UserViewModel>>
            GetVisibleAsync(int startIndex , int count )
        {
            RequestUri = $"{ BaseUrl }/{ GetApiUrl() }/getVisibleUsers/{startIndex}/{count}";

            var result = await GetAsync<System.Collections.Generic.List<ViewModels.User.UserViewModel>>();

            return result; 
        }

    }
}
