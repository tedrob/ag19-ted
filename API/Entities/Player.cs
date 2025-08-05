using System;

namespace API.Entities;

public class Player
{
public int Id { get; set; }
public required string PlayerName { get; set; }
public required string Description { get; set; }
public DateTime Created { get; set; } = DateTime.UtcNow;
}
