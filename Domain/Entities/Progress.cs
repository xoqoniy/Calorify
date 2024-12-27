using Domain.Audibles;

namespace Domain.Entities;

public class Progress : Audible
{
    public string UserId { get; set; } // Foreign key to User table
    public float Weight { get; set; } // Weight recorded
    public DateTime Date { get; set; }
    public float TotalProtein { get; set; }
    public float TotalCarbs { get; set; }
    public float TotalFat { get; set; }
    public float CaloriesConsumed { get; set; } // Total calories logged for the day
    public float CaloriesBurned { get; set; } // Total calories burned for the day
}
