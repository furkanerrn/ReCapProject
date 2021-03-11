using Core.Entities;

namespace Entities.Concrete
{
    public class UserForLoginDto : IDTo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
