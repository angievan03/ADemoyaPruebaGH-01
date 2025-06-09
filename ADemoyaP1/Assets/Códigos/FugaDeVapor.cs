using UnityEngine;

public class FugaDeVapor : MonoBehaviour
{
    public ParticleSystem vapor;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !vapor.isPlaying)
        {
            vapor.Play();
        }
    }
}
