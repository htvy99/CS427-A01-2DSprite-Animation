using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDogController : MonoBehaviour
{
    public GameObject pinkDog;
    public GameObject heart;
    Animator heartAnim;
    // Start is called before the first frame update
    void Start()
    {
        heartAnim = heart.GetComponent<Animator>();
    }
    public void VisibleObj() {
        heartAnim.GetComponent<SpriteRenderer>().enabled = true;
    }
    public void InvisibleObj() {
        heartAnim.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void SetTriggerHeart() {
        heartAnim.SetTrigger("HeartTrigger");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SetTriggerHeart();
        }
    }
}
