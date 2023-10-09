using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI nameText;

    [SerializeField]
    TextMeshProUGUI moneyText;


    void Awake()
    {
        nameText.text = StateManager.Instance.getName();
        moneyText.text = "$" + StateManager.Instance.getPrize().ToString("#,##0.00");
    }


    public void StartAgain()
    {
        LevelManager.Instance.FirstScene();
    }


}
