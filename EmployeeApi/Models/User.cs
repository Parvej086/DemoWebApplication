namespace EmployeeApi.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // Can be "Admin", "User", etc.
    }
}
