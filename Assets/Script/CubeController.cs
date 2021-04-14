using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float deadLine = -10;

    public AudioClip Block;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collider2D other)
    {
        if (other.tag == "GroundTag")
        {
            this.GetComponent<AudioSource>().volume = 0.3f;
            Debug.Log("音");
        }

        else
        {
            this.GetComponent<AudioSource>().volume = 0;
            Debug.Log("無");

        }
    }
}
