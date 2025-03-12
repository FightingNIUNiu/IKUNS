using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float score = 0;
    public Text text;

    void Start()
    {
        text.text = "Score:\n0.0"; // Reset text
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "��ϰʱ��:\n" + score.ToString("F1") + "��"; // Update text
    }

    // Update score
    public static void UpdateScore(float updateValue)
    {
        GameManager.score += updateValue;
    }
}
