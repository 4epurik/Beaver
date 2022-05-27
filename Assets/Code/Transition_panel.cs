using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_panel : MonoBehaviour
{
    public GameObject trans;
    public Animator trans_anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        trans.gameObject.SetActive(true);
        trans_anim.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trans.gameObject.SetActive(false);
        trans_anim.enabled = false;
    }
}
