using Domain.Audibles;

namespace Domain.Entities;

public class Exercise : Audible
{
    public string UserId { get; set; } // Foreign key to User table
    public string ExerciseType { get; set; } // e.g., running, swimming, cycling
    public float Duration { get; set; } // Duration in minutes
    public float CaloriesBurned { get; set; }
}