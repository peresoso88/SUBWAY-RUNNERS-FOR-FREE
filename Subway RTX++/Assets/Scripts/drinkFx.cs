using UnityEngine;

public class drinkFx : MonoBehaviour
{
    [SerializeField] AudioSource DrinkFx;

    void OnTriggerEnter(Collider other)
    {
        DrinkFx.Play();
        this.gameObject.SetActive(false);
    }
}
