﻿namespace Persistence.Models;
public class User
{
    public Guid Id { get; init; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public bool IsAdmin { get; set; }

}
