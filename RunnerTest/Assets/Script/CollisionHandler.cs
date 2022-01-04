using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    int lives = 3; //How many hits you need to respawn.
    public GameObject live;
    public GameObject live1;
    public GameObject live2;

    void Update()
    {
        ProcessCollision();    //Check the status every frame.
    }

    
    void ProcessCollision()
    {
        switch (lives)
        {
                case 2:
            Destroy(live2);
            break;
                case 1:
            Destroy(live1);
            break;
                case 0:
            Respawn();
            break;

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
