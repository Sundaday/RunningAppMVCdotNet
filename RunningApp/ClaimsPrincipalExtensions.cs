using System.Security.Claims;

namespace RunningApp
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user) //Find a way to put this into controller
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
