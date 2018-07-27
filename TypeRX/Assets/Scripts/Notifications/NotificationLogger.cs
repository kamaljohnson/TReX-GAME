using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationLogger : MonoBehaviour {

    public Text message;

    public static List<string> LoggerQueue = new List<string>();
    bool log_task_completed;

    readonly float min_delay_between_notifications = 1;
    bool start_timer;
    float count_down_time;

    private void Start()
    {
        log_task_completed = true;
        message.text = "";
        start_timer = false;
        count_down_time = min_delay_between_notifications;
    }

    private void Update()
    {
        if(start_timer)
        {
            count_down_time -= Time.deltaTime;
        }
        if(count_down_time < 0)
        {
            message.text = "";
            start_timer = false;
            log_task_completed = true;
        }
        if(log_task_completed && LoggerQueue.Count != 0)
        {
            Log();
            log_task_completed = false;
        }
    }
    void Log()
    {
        message.text = LoggerQueue[0];
        LoggerQueue.RemoveAt(0);
        count_down_time = min_delay_between_notifications;

        start_timer = true;
    }

    public static void Load(string msg)
    {
        LoggerQueue.Add(msg);
    }
}
