
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{


    private AudioSource collisionSound;
    public GameObject fx;
    public GameObject worldObject;
    void Start()
    {
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
        worldObject = GameObject.Find("World");

    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter
        worldObject.SendMessage("AddHit");
        if (other.tag == "Player")
        {
            if (collisionSound)
            {
                collisionSound.Play();
                Instantiate(fx, transform.position, Quaternion.identity);
            }


            if (fx)
            {
                Instantiate(fx, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
 
  

}

