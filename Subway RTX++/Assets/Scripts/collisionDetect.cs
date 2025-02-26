using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class collisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] AudioSource DeathFx;
    [SerializeField] GameObject DeadBg;
    [SerializeField] GameObject BloodAn;
    [SerializeField] GameObject CountAn;
    [SerializeField] GameObject Wasted;

    public CharacterMovement CharacterMovement;
    

    void OnTriggerEnter(Collider other)
    {

        StartCoroutine(CollisionEnd());
    }
    private IEnumerator CollisionEnd()
    {
        DeathFx.Play();
        CharacterMovement.animator.SetBool("Dead", true);
        thePlayer.GetComponent<CharacterMovement>().enabled = false;
        DeadBg.SetActive(true);
        yield return new WaitForSeconds(2);
        BloodAn.SetActive(true);
        CountAn.SetActive(true);
        Wasted.SetActive(true);
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);

    }


}
