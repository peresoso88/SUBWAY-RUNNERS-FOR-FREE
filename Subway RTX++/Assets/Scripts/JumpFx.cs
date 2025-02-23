using UnityEngine;

public class JumpFx : MonoBehaviour
{
    [SerializeField] AudioSource jumpFx;

    void OnTriggerEnter(Collider other)
    {
        jumpFx.Play();
        this.gameObject.SetActive(false);
    }
}
