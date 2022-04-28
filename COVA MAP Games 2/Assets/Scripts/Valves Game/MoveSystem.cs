using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Drag and drop system for the valves game

public class MoveSystem : MonoBehaviour
{
    private float StartPosX;
    private float StartPosY;
    private float startx;
    private float starty;

    Collider other;

    public ValvesCSV ValvesCSVScript;

    public ScoringValves ScoringValvesScript;

    public GameObject prefab;
    GameObject IncorrectIndicator;

    private void Start()
    {
        DontDestroy.NumberCorrect = 0;

    }

    private void OnMouseDown()
    {
        startx = transform.position.x;
        starty = transform.position.y;
        StartPosX = Cursor3D.Position.x - transform.position.x;
        StartPosY = Cursor3D.Position.y - transform.position.y;
    }
    private void OnMouseDrag()
    {
        //Debug.Log("mouse drag");
        Vector3 CurrentPos = transform.position;
        this.gameObject.transform.position = new Vector3(Cursor3D.Position.x - StartPosX, Cursor3D.Position.y - StartPosY, transform.position.z);
        //Debug.Log(Input.mousePosition.x);
    }
    private void OnMouseUp()
    {
        Debug.Log("mouse up");

       // OnTriggerEnter;

        this.gameObject.transform.position = new Vector3(startx, starty, transform.position.z);

        if (other != null)
        {
            ValveSpot spot = other.GetComponent<ValveSpot>();
            if (spot != null && spot.Contains(gameObject, out ValveSpot.CorrectValveStruct result))
            {
                // This is the right one
                Debug.Log("INDEXVALVE: " + ValvesCSVScript.indexValve);
                ValvesCSVScript.ValveSpotsList[ValvesCSVScript.indexValve].GetComponent<Collider>().enabled = false;

                DontDestroy.NumberTimesCheckedPerValve = DontDestroy.NumberTimesChecked - DontDestroy.NumberTimesCheckedPerValve;
                DontDestroy.NumberTimesCheckedPerValveArray[ValvesCSVScript.indexValve] = (DontDestroy.NumberTimesCheckedPerValve);

                //ValvesCSVScript.ActualValveList[ValvesCSVScript.indexValve].SetActive(true);
                result.objectToEnable.SetActive(true);

                DontDestroy.NumberCorrect = DontDestroy.NumberCorrect + 1;

                //Go to next discription
                ValvesCSVScript.DisplayCorrectValveDescription();

                ScoringValvesScript.GetScore();

                this.other = null;
            }
            else
            {
                // This is the wrong one
                Debug.Log("An X shows now. This is incorrect.");
                // Make X show
                IncorrectIndicator = Instantiate(prefab, new Vector3(Cursor3D.Position.x - StartPosX, Cursor3D.Position.y - StartPosY, transform.position.z), Quaternion.identity);

                DontDestroy.NumberTimesChecked = DontDestroy.NumberTimesChecked + 1;

                if(DontDestroy.NumberTimesChecked == 3)
                {
                    DontDestroy.NumberTimesCheckedPerValveArray[ValvesCSVScript.indexValve] = 3;
                }

                ScoringValvesScript.GetScore();

                //this.other = null;

                StartCoroutine(HideX(IncorrectIndicator));
            }
        }
    }

    public IEnumerator HideX(GameObject x)
    {
        yield return new WaitForSeconds(1);
        Destroy(x);

        //Debug.Log("got here");
    }

    void OnTriggerEnter(Collider other)
    {
        print("on trigger enterrrrr");
        Debug.Log(other.gameObject.name);
        this.other = other;
    }

    private void OnTriggerExit(Collider other)
    {
        this.other = null;
    }

}