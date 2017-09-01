using UnityEngine;

public abstract class Sington<T> : MonoBehaviour where T:MonoBehaviour
{

    private static T _instance;

    public static T Instance
    {
        get
        {
            _instance = GameObject.FindObjectOfType<T>();
            if (_instance == null)
            {
                GameObject gb = new GameObject(typeof(T).Name);
                _instance = gb.AddComponent<T>();
            }

            return _instance;
        }

        set
        {
            _instance = value;
        }
    }


}
