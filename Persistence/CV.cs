namespace Persistence;

public class CV
{
    public int CVID{get; set;}
    public string? FullName{get; set;}
    public string? CareerTitle{get; set;}
    public string? CareerObjective{get; set;}
    public DateTime BirthDate{get; set;}
    public string? PhoneNum{get; set;}
    public string? Email{get; set;}
    public string? SocialMedia{get; set;}
    public string? PersonalAddress{get; set;}
    public List<CVDetails>? CVDetails{get; set;}

}