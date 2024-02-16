using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private UIManager uiManager;

    [Header("ƒQ[ƒ€ŽžŠÔ")]
    public int gameTime;

    private float timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateDisplayGameTime(gameTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if(timeCounter >= 1.0f)
        {
            timeCounter = 0;
            gameTime--;
            if(gameTime <= 0)
            {
                gameTime = 0;
            }
            uiManager.UpdateDisplayGameTime(gameTime);
        }
    }
}
