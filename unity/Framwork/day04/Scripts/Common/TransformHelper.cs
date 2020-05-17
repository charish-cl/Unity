using UnityEngine;
using System.Collections;

public class TransformHelper : MonoBehaviour {

	//找到FindChild 放在这里 递归！

    /// <summary>
    /// 转向
    /// </summary>
    public static void LookAtTarget(Vector3 target, 
        Transform transform, float rotationSpeed)
    {
        if (target != Vector3.zero)
        {
            Quaternion dir = Quaternion.LookRotation(target);
            transform.rotation = Quaternion.Lerp(transform.rotation, 
                dir, rotationSpeed);
        }
    }
}
