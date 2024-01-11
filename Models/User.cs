using Microsoft.AspNetCore.Identity;
namespace benchTime.Models;

public class User : IdentityUser {

  public string firstName { get; set; }
  public string lastName { get; set; }
}