using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRemover : MonoBehaviour
{
    GameObject text;
    [SerializeField] float destroyTime = 10;
    // Removes the Tutorial after x seconds.
    void Start()
    {
        text = this.gameObject.transform.GetChild(0).gameObject;
        Destroy(text, destroyTime);
    }
}
