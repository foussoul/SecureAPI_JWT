// AddRoleModel.cs
namespace SecureAPI_JWT.Models
{
    public class AddRoleModel
    {
        public string UserId { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}