using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TrialButtonCircle : MonoBehaviour
{
    public Button yourButton;
    public CanvasRenderer yourDraggable1;
    public CanvasRenderer yourDraggable2;
    public CanvasRenderer yourDraggable3;
    public CanvasRenderer yourDraggable4;
    public CanvasRenderer yourDrop1;
    public CanvasRenderer yourDrop2;

    public CanvasRenderer yourCanvas;
    public CanvasRenderer yourString;
    public CanvasRenderer yourX;

    public bool clicked;
    public bool condition;

    void Start()
    {
        //CanvasRenderer canvasRenderer1 = yourDraggable1.GetComponent<CanvasRenderer>();
        //canvasRenderer1.cull = true;

        /*CanvasRenderer canvasRenderer2 = yourDraggable2.GetComponent<CanvasRenderer>();
        canvasRenderer2.cull = true;

        CanvasRenderer canvasRenderer3 = yourDraggable3.GetComponent<CanvasRenderer>();
        canvasRenderer3.cull = true;

        CanvasRenderer canvasRenderer4 = yourDraggable4.GetComponent<CanvasRenderer>();
        canvasRenderer4.cull = true;

        CanvasRenderer canvasRenderer5 = yourDrop1.GetComponent<CanvasRenderer>();
        canvasRenderer5.cull = true;

        CanvasRenderer canvasRenderer6 = yourDrop2.GetComponent<CanvasRenderer>();
        canvasRenderer6.cull = true;

        CanvasRenderer canvasRenderer7 = yourCanvas.GetComponent<CanvasRenderer>();
        canvasRenderer7.cull = true;

        CanvasRenderer canvasRenderer8 = yourString.GetComponent<CanvasRenderer>();
        canvasRenderer8.cull = true;

        CanvasRenderer canvasRenderer999 = yourX.GetComponent<CanvasRenderer>();
        canvasRenderer999.cull = true;*/

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {

        if (clicked == true)
        {
            Debug.Log("TITE");
            CanvasRenderer canvasRenderer1 = yourDraggable1.GetComponent<CanvasRenderer>();
            canvasRenderer1.cull = true;

            CanvasRenderer canvasRenderer2 = yourDraggable2.GetComponent<CanvasRenderer>();
            canvasRenderer2.cull = true;

            CanvasRenderer canvasRenderer3 = yourDraggable3.GetComponent<CanvasRenderer>();
            canvasRenderer3.cull = true;

            CanvasRenderer canvasRenderer4 = yourDraggable4.GetComponent<CanvasRenderer>();
            canvasRenderer4.cull = true;

            CanvasRenderer canvasRenderer5 = yourDrop1.GetComponent<CanvasRenderer>();
            canvasRenderer5.cull = true;

            CanvasRenderer canvasRenderer6 = yourDrop2.GetComponent<CanvasRenderer>();
            canvasRenderer6.cull = true;

            CanvasRenderer canvasRenderer7 = yourCanvas.GetComponent<CanvasRenderer>();
            canvasRenderer7.cull = true;

            CanvasRenderer canvasRenderer8 = yourString.GetComponent<CanvasRenderer>();
            canvasRenderer8.cull = true;

            CanvasRenderer canvasRenderer999 = yourX.GetComponent<CanvasRenderer>();
            canvasRenderer999.cull = true;
        }else if(clicked == false)
        {
            Debug.Log("PEPE");
            CanvasRenderer canvasRenderer1 = yourDraggable1.GetComponent<CanvasRenderer>();
            canvasRenderer1.cull = false;

            CanvasRenderer canvasRenderer2 = yourDraggable2.GetComponent<CanvasRenderer>();
            canvasRenderer2.cull = false;

            CanvasRenderer canvasRenderer3 = yourDraggable3.GetComponent<CanvasRenderer>();
            canvasRenderer3.cull = false;

            CanvasRenderer canvasRenderer4 = yourDraggable4.GetComponent<CanvasRenderer>();
            canvasRenderer4.cull = false;

            CanvasRenderer canvasRenderer5 = yourDrop1.GetComponent<CanvasRenderer>();
            canvasRenderer5.cull = false;

            CanvasRenderer canvasRenderer6 = yourDrop2.GetComponent<CanvasRenderer>();
            canvasRenderer6.cull = false;

            CanvasRenderer canvasRenderer7 = yourCanvas.GetComponent<CanvasRenderer>();
            canvasRenderer7.cull = false;

            CanvasRenderer canvasRenderer8 = yourString.GetComponent<CanvasRenderer>();
            canvasRenderer8.cull = false;

            CanvasRenderer canvasRenderer999 = yourX.GetComponent<CanvasRenderer>();
            canvasRenderer999.cull = false;
        }

        
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the buttonCircle!");
        //GameObject.Find("ButtonX").transform.localScale = new Vector3(1, (float)2.9, 1);
        //GameObject.Find("DraggableSlots").transform.localScale = new Vector3(1, 1, 1);
        //GameObject.Find("ButtonCircle").transform.localScale = new Vector3(0, 0, 0);
        //CanvasRenderer canvasRenderer = GetComponent<CanvasRenderer>();
        //yourCanvas = canvasRenderer;
        // yourCanvas.cull = true;
        //GetComponent<CanvasRenderer>().cull = true;


    }
}
