using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(GameManager.gm)
            {
                other.transform.position = GameManager.gm.lastPos;
            }
    }
}
