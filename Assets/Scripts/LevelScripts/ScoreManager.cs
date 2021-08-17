using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject bar;
    public TextMeshProUGUI CoinText;
    private int coin = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }   
    }

    public void ChangeScore(int coinvalue)
    {
        coin=coin+coinvalue;
        CoinText.text = "x" + coin.ToString();
        if (coin==10)
        {
            Destroy(bar);
        }
    }
}
