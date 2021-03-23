using System.Collections.Generic;
using System.Linq;

namespace Server.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class UsersController : Microsoft.AspNetCore.Mvc.ControllerBase
    {

        [Microsoft.AspNetCore.Mvc.HttpGet("getAllUsers")]
        public async 
            System.Threading.Tasks.Task<System.Collections.Generic.List<ViewModels.User.UserViewModel>>
            GetAllUsers()
        {
            System.Collections.Generic.List<ViewModels.User.UserViewModel> users = 
                new System.Collections.Generic.List<ViewModels.User.UserViewModel>();

            await System.Threading.Tasks.Task.Run(()=>
            {
                users.AddRange(Enumerable.Range(0,20001)
                .Select(current => new ViewModels.User.UserViewModel
                {
                    Username = $"Username {current}",
                    FullName = $"FullName {current}",
                }));
            });
              
            return users;
        }


        [Microsoft.AspNetCore.Mvc.HttpGet("getVisibleUsers/{startIndex}/{count}")]
        public async
            System.Threading.Tasks.Task<System.Collections.Generic.List<ViewModels.User.UserViewModel>>
            GetVisibleUsers(int startIndex , int count)
        {
            System.Collections.Generic.List<ViewModels.User.UserViewModel> users = 
                new System.Collections.Generic.List<ViewModels.User.UserViewModel>();

            await System.Threading.Tasks.Task.Run(() =>
            {
                users.AddRange(Enumerable.Range(startIndex , count).
                Select(current => new ViewModels.User.UserViewModel
                {
                    Username = $"Username {current}",
                    FullName = $"FullName {current}",
                }));

            });

            return users;
        }
    }
}