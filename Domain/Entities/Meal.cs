using Domain.Audibles;
using Domain.Enums;

namespace Domain.Entities;

public class Meal : Audible
{
    public string UserId { get; set; } // Foreign key to User table
    public MealType MealType { get; set; } // (breakfast, lunch, dinner, snack)
    public string PhotoUrl { get; set; } // If the user uploaded a meal photo
    public string FoodItems { get; set; } // JSON format - list of food items
    public ushort TotalCalories { get; set; }
    public float TotalProtein { get; set; }
    public float TotalCarbs { get; set; }
    public float TotalFat { get; set; }
}