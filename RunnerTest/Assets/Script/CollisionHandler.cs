using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    int lives = 3; //How many hits you need to respawn.
    void Update()
    {
        ProcessCollision();    //Check the status every frame.
    }

    
    void ProcessCollision()
    {
        if (lives == 0) //If you dont have any lives left, you respawn.
        {
            Respawn();
        }
    }

    void Respawn() //The respawn method using the SceneManager.
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void OnCollisionEnter(Collision other) //You get -1 life for every collicsion.
    {
        lives = lives -1;    
    }
}
