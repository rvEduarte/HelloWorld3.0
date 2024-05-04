using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TrialButtonCircle : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the buttonCircle!");
        GameObject.Find("ButtonX").transform.localScale = new Vector3(1, (float)2.9, 1);
        GameObject.Find("DraggableSlots").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("ButtonCircle").transform.localScale = new Vector3(0, 0, 0);
    }
}
