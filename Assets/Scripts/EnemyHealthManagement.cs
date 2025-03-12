using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManagement : MonoBehaviour
{
    public float totalHealth = 20.0f;
    public float value = 2.5f;

    // Update is called once per frame
    void Update()
    {
        // If health is lower than 0, destory itself
        if (totalHealth < 0)
        {
            EnemyDestroy.DestroySelf(this.gameObject);
            GameManager.UpdateScore(value);
        }
    }

    // If get hit by others
    public void GetHit(float hitValue)
    { 
        totalHealth -= hitValue;
    }
}
