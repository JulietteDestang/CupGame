using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private GameObject timerText;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject button;
    private float time;

    void Update()
    {
        time = Time.timeSinceLevelLoad;
        if (time >= 120)
        {
            if (!button.activeSelf)
            {
                timerText.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Finish !";
                scoreText.transform.position = new Vector3(11, -2, 0);
                button.SetActive(true);
            }
            return;
        }
        timerText.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = string.Format("{0:0}:{1:00}", Mathf.Floor(time/60), time%60);

        if (time >= 110)
        {
            timerText.GetComponentInChildren<TMPro.TextMeshProUGUI>().color = new Color(255, 0, 0, 255);
        }
    }
}
