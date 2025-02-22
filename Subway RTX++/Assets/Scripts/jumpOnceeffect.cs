using UnityEngine;

public class jumpOnceeffect : MonoBehaviour
{
    [SerializeField] AudioSource jumpFx;

    void OnTriggerEnter(Collider other)
    {
        jumpFx.Play();
        this.gameObject.SetActive(false);
    }
}
