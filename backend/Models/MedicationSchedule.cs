using System.ComponentModel.DataAnnotations;
namespace backend.Models
{

    /* I was initially very confused on how to implements this. Especially since the times a medication can be taken daily varies greatly.
    I decided on retrieving the number of pills a day as well as a start date (when the first pill will be taken).
    I will then send a reminder every 24hrs/number of pills. so choosing 3 pills a day will send a reminder Every 24/3=8rs.
    In the future, I aim to allow users to dynamically select the time they'd like to be reminded.

    */
    public class MedicationSchedule
    {
        [Key]
        public int Id{get; set;}

        public User User{get; set;}=null!;

        public Medication Medication{get; set;}=null!;

        public int NumberOfPills{get; set;}

        public int Duration{get; set;}

        public DateOnly? StartDate{get; set;}

        public DateOnly? EndDate{get; set;}

        public List<ReminderPlanning> ReminderPlannings{get; set;}=new List<ReminderPlanning>();





    }
}