using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Person
{
  public int Id { get; set; }
  [Required]
  [MaxLength(30)]
  public String FirstName { get; set; } = String.Empty;
  [Required]
  [MaxLength(30)]
  public String LastName { get; set; } = String.Empty;
}
