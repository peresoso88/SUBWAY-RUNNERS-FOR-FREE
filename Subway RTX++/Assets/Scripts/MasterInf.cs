using UnityEngine;

public class MasterInf : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject ScoreFinal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins:" + coinCount;
        ScoreFinal.GetComponent<TMPro.TMP_Text>().text = "Total Score:" + coinCount;
    }
}
