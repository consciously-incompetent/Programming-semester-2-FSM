using UnityEngine;

public class SingleTon<t> : MonoBehaviour where t : MonoBehaviour
{
    private static t instance;
    public static t Instance
    { get
        {
            return getInstance();
        }
    }

    private static t getInstance()
    {
        if(instance == null)
        {
            instance = FindFirstObjectByType<t>();
            if(instance == null)
            {
                GameObject go = new(typeof(t).ToString(), typeof(t));
                instance = go.GetComponent<t>();

                DontDestroyOnLoad(go);
            }
            else if (instance.gameObject.scene.name != "DontDestroyOnLoad")
            {
                DontDestroyOnLoad(instance.gameObject);
            }
        }
        return instance;

    }

    private void Awake()
    {
        getInstance();

        if(instance && instance != this)
        {
            Debug.LogWarning("duplicate");
            Destroy(this);
        }
    }
}
