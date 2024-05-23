using System.ComponentModel.DataAnnotations;

namespace BlazorWebshop.Models;

public class Customer
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
