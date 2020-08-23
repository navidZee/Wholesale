using Wholesale.Domain.Common.Base;

namespace Wholesale.Domain.Entities.SEC
{
    public class UserEntity : BaseEntity
    {
        public UserEntity() { }

        public string Password { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string DisplayName { get; set; }
        
    }
}
