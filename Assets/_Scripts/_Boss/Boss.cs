using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Bullet")
        {
            BossManager.instance.detectBoss(false);
            Destroy(gameObject);
        }
        else
        {
            BossManager.instance.detectBoss(true);
        }
    }
}
