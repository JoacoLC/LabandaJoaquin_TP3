using UnityEngine;
using Platformer.Mechanics;
using System;

public class JumpingEnemy : MonoBehaviour
{
    public AnimationController animController;
    public double timer = 0;
    public double initTimer = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initializeTimer(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            animController.jump = true;
            initializeTimer();
        }
        else
        {
            timer -= Time.deltaTime;
            animController.jump = false;
        }
    }

    void initializeTimer()
    {
        timer = initTimer + 0.05 * UnityEngine.Random.Range(0, 5);
        UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
    }
}
