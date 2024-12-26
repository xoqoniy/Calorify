namespace Domain.Audibles;

public abstract class Audible
{
    public string _id {get; set;}
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
}