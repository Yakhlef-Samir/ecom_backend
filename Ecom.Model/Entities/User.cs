using Ecom.Model.Enums;

namespace Ecom.Model.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public bool isActive { get; set; }
    public UserRole Role { get; set; }
	public DateTime CreatedAt { get; set; }
    public DateTime? LastLoginAt { get; set; }
}                           