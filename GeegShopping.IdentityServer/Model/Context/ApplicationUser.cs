using Microsoft.AspNetCore.Identity;

namespace GeegShopping.IdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
    }
}
