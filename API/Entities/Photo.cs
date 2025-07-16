using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Routing;

namespace API.Entities;

public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public string? publicId { get; set; }

    // Navigation property
    [JsonIgnore]
    public Member Member { get; set; } = null!;
    public string MemberId { get; set; } = null!;
}
