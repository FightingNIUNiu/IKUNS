using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    void Update()
    {
        // Destroy itself when the Pos.Z value is lower than -15 (Disappear from the camera view)
        if (this.transform.position.z < -15.0f)
            DestroySelf(this.gameObject);
    }

    public static void DestroySelf(GameObject obj)
    {
        Destroy(obj); // Destroy the object itself
    }
}
