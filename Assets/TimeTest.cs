using System.Threading;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class TimeTest : MonoBehaviour
{
    float timecount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Time.time);
    }

    void Update()
    {
        timecount += Time.deltaTime;
        if (timecount > 5)
        {
            Debug.Log("5 seconds has passed, two new balls to you!");
            timecount = 0;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}