using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class mole : MonoBehaviour
{
    private float startHeight;
    private float hideHeight = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    private void Hide()
    {
        startHeight = transform.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y - hideHeight, transform.position.z);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.tag);
            HeadUp();
        }
    }

    private void HeadUp()
    {
        transform.DOMoveY(startHeight, 0.25f);
    }
}
