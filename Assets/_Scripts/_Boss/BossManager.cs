using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    GameObject lights;
    public static BossManager instance;

    public bool boss = false;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void detectBoss (bool bossDetect)
    {
        boss = bossDetect;
        
        if(boss = true)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
    }
}
