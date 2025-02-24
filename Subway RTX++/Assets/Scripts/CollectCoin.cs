using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinFx;
    private CapsuleCollider capsuleCollider;

     void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        MasterInf.coinCount += 1;
        
        this.gameObject.SetActive(false);
    }
}
