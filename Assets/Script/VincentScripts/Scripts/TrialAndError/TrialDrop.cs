using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrialDrop : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameObject Gunportal;

    private void Start()
    {

        Gunportal.SetActive(false);
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("helloworld"))
        {
            Debug.Log("ENTERWORLD");
            Gunportal.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("helloworld"))
        {

            Gunportal.gameObject.SetActive(false);
        }
    }
}