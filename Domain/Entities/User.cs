using Domain.Audibles;
using Domain.Enums;

namespace Domain.Entities;

public class User : Audible
{
        public string Name {get; set;}
        public DateTime Birthday {get; set;}
        public Gender Gender { get;  set; }
        public ushort Weight { get; set; }    // in kg
        public byte Height { get; set; } //centimers 
        public ActivityLevel ActivityLevel {get; set;} 
        public ushort TargetWeight { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public Goal Goal {get; set;}  //lose/maintain/gain weight
        public  DateTime TimeFrame {get; set;}
        public SubscribtionStatus Status { get; set; } = SubscribtionStatus.Inactive;
        public ushort CalorieTarget { get; set; }        
        public string ConnectedServices {get; set;}
}