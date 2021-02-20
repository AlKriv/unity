using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGround : MonoBehaviour
{
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            gameObject.GetComponentInParent<Player>().isGrounded = false;
            gameObject.GetComponentInParent<Player>().anim.SetInteger("state", 3);
        }
        Debug.Log("OnTriggerExit2D");

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player")
            gameObject.GetComponentInParent<Player>().isGrounded = true;
        Debug.Log("OnTriggerStay2D");
    }
}
