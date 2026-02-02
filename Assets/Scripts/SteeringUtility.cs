using UnityEngine;

public static class SteeringUtility
{
    public static Vector3 seek(Vector3 pos, Vector3 target)
    {
        return (target - pos).normalized;
    }

    public static Vector3 flee(Vector3 pos, Vector3 target)
        => seek(target, pos);
    
}
