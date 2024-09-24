using System;

namespace Program.Models;

public class AppUser:BaseModel
{
public string Email { get; set; }
public string Password { get; set; }
public int UserTypeId { get; set; }
public virtual UserType UserType { get; set; }
}
