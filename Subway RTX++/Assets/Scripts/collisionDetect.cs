using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] AudioSource DeathFx;

     void OnTriggerEnter(Collider other)
    {
        DeathFx.Play();
        thePlayer.GetComponent<CharacterMovement>().enabled = false;
    }
}
