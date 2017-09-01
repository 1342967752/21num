using UnityEngine;

public class Debuger  {

    //是否能debug
    private const bool canDebug = true; 

    public static void Log(object msg)
    {
        if (canDebug)
        {
            Debug.Log(msg);
        }
        
    }

    public static void LogError(object msg)
    {
        if (!canDebug)
        {
            return;
        }

        Debug.LogError(msg);
    }
}
