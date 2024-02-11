using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tree : MonoBehaviour
{
    [Header("‰ñ“]‚·‚éŽžŠÔ")]
    public float duration;
    private bool isRotate = false;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && isRotate == false)
        {
            Rotate();
            isRotate = true;
        }
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(0, 0, RandomAngle()), duration);
    }

    private float RandomAngle()
    {
        int value = Random.Range(0, 2);
        if(value == 0)
        {
            return 70.0f;
        }
        else
        {
            return -70.0f;
        }
    }

}
   
