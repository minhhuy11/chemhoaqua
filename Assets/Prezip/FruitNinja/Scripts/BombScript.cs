using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    private float rotationForce = 200;
    public ParticleSystem explosionParticle;
    public AudioClip sliceSound;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector2.right * Time.deltaTime * rotationForce);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Blade")
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            FindObjectOfType<GameManager>().GameOver();
            if (sliceSound != null)
            {
                AudioSource.PlayClipAtPoint(sliceSound, transform.position);
            }
        }

    }
}
