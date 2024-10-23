using UnityEngine;

public class planner : MonoBehaviour

{
    private string[] tasks = new string[7];

    void Start()
    {
        InitializeTasks();
        PrintTasks();
    }

    void InitializeTasks()
    {
        tasks[(int)Day.Monday] = "Arbeide med gruppen";
        tasks[(int)Day.Tuesday] = "IKDU forelesning";
        tasks[(int)Day.Wednesday] = "PBL forelesning";
        tasks[(int)Day.Thursday] = "IKDU forelesning";
        tasks[(int)Day.Friday] = "Rapportskriving med gruppen";
        tasks[(int)Day.Saturday] = "Trene på Sats";
        tasks[(int)Day.Sunday] = "Gøre kreativt arbeid";
    }

    void PrintTasks()
    {
        for (int i = 0; i < tasks.Length; i++)
        {
            Debug.Log(((Day)i).ToString() + ": " + tasks[i]);
        }
    }
}