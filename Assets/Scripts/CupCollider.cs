using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CupCollider : MonoBehaviour
{
    [SerializeField] private UnityEvent m_AddScoreEvent;
    [SerializeField] private GameObject floatingAnimation;

    void Start()
    {
        floatingAnimation.GetComponentInChildren<TextMesh>().text = "+1 point !";
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball" && collision.gameObject.GetComponent<Renderer>().material.color == GetComponent<Renderer>().material.color)
        {
            Vector3 instantiatePosition = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);
            Instantiate(floatingAnimation, instantiatePosition, Quaternion.identity);

            m_AddScoreEvent.Invoke();

            Destroy(collision.gameObject);
        } 
    }

}