using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    public int point;
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.TryGetComponent(out Playercontroller player))
        {
            player.AddScore(point);
        }
        Destroy(gameObject, 1.0f);
    }
}
