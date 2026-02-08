namespace UserPortal.Models;

public class User
{
    public int Id { get; set; }
    public string Nickname { get; set; }
    public string Status { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLogin { get; set; }
}