using System.ComponentModel.DataAnnotations;

namespace TeamMembers.Data.Models;

public record Person()
{
    [Key]
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public string? Avatar { get; init; }
}