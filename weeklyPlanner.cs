using UnityEngine;

    public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class weeklyPlanner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


void ScheduleTask(Day day)
{
    switch (day)
    {
        case Day.Monday:
            Debug.Log("Task for Monday");
            break;
        case Day.Tuesday:
            Debug.Log("Task for Tuesday");
            break;
        case Day.Wednesday:
            Debug.Log("Task for Wednesday");
            break;
        case Day.Thursday:
            Debug.Log("Task for Thursday");
            break;
        case Day.Friday:
            Debug.Log("Task for Friday");
            break;
        case Day.Saturday:
            Debug.Log("Task for Saturday");
            break;
        case Day.Sunday:
            Debug.Log("Task for Sunday");
            break;
        default:
            Debug.Log("Invalid day");
            break;
    }

}
    }
   
 }   
