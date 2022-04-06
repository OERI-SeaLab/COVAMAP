using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswers : MonoBehaviour
{
    public GameObject CheckButtonPannel;
    public IncorrectEndElectricalGame IncorrectEndElectricalGameScript;
    public CorrectElectricalGame CorrectElectricalGameScript;

    public GameObject wire1;
    public GameObject wire2;
    public GameObject wire3;
    public GameObject wire4;
    public GameObject wire5;
    public GameObject wire6;
    public GameObject wire7;
    public GameObject wire8;
    public GameObject wire9;
    public GameObject wire10;
    public GameObject wire11;
    public GameObject wire12;
    public GameObject wire13;
    public GameObject wire14;
    public GameObject wire15;
    public GameObject wire16;

    public GameObject connector1;
    public GameObject connector2;
    public GameObject connector3;
    public GameObject connector4;
    public GameObject connector5;
    public GameObject connector6;
    public GameObject connector7;
    public GameObject connector8;
    public GameObject connector9;
    public GameObject connector10;
    public GameObject connector11;
    public GameObject connector12;
    public GameObject connector13;
    public GameObject connector14;
    public GameObject connector15;
    public GameObject connector16;



    public void Start()
    {
        CheckButtonPannel.SetActive(true);
        DontDestroy.ElectricalWon = false;
    }

    // Update is called once per frame
    public void CheckAnswerElectrical()
    {
        if (DontDestroy.ScenarioCounter == 1)
        {
            print("scenario 1");
            //black on A  //wiretype 4
            //white on C
            if (connector1.GetComponent<BoxCollider>().enabled == true
                && wire1.GetComponent<MeshRenderer>().material.color == Color.white 
                && wire1.GetComponent<WireType>().TheWireType == 4 
                && wire2.GetComponent<MeshRenderer>().material.color == Color.black 
                && wire2.GetComponent<WireType>().TheWireType == 4
                ||
                connector7.GetComponent<BoxCollider>().enabled == true
                && wire7.GetComponent<MeshRenderer>().material.color == Color.white
                && wire7.GetComponent<WireType>().TheWireType == 4
                && wire8.GetComponent<MeshRenderer>().material.color == Color.black
                && wire8.GetComponent<WireType>().TheWireType == 4
                ||
                connector10.GetComponent<BoxCollider>().enabled == true
                && wire10.GetComponent<MeshRenderer>().material.color == Color.white
                && wire10.GetComponent<WireType>().TheWireType == 4
                && wire9.GetComponent<MeshRenderer>().material.color == Color.black
                && wire9.GetComponent<WireType>().TheWireType == 4
                ||
                connector16.GetComponent<BoxCollider>().enabled == true
                && wire16.GetComponent<MeshRenderer>().material.color == Color.white
                && wire16.GetComponent<WireType>().TheWireType == 4
                && wire15.GetComponent<MeshRenderer>().material.color == Color.black
                && wire15.GetComponent<WireType>().TheWireType == 4)
            {
                print("correct");
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                print("not correct");
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 2)
        {
            print("scenario 2");
            //red on B   type 4
            //blue on C
            if (
                connector3.GetComponent<BoxCollider>().enabled == true
                && wire3.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire3.GetComponent<WireType>().TheWireType == 4
                && wire4.GetComponent<MeshRenderer>().material.color == Color.red
                && wire4.GetComponent<WireType>().TheWireType == 4
                ||
                connector14.GetComponent<BoxCollider>().enabled == true
                && wire14.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire14.GetComponent<WireType>().TheWireType == 4
                && wire13.GetComponent<MeshRenderer>().material.color == Color.red
                && wire13.GetComponent<WireType>().TheWireType == 4)
            {
                print("correct!");
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                print("NOT correct!");
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 3)
        {
            print("scenario 3");
            //blue on B   type 4
            //red on C
            if (connector3.GetComponent<BoxCollider>().enabled == true
                && wire3.GetComponent<MeshRenderer>().material.color == Color.red
                && wire3.GetComponent<WireType>().TheWireType == 4
                && wire4.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire4.GetComponent<WireType>().TheWireType == 4
                ||
                connector14.GetComponent<BoxCollider>().enabled == true
                && wire14.GetComponent<MeshRenderer>().material.color == Color.red
                && wire14.GetComponent<WireType>().TheWireType == 4
                && wire13.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire13.GetComponent<WireType>().TheWireType == 4)
            {
                print("correct!");
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                print("NOT correct!");
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 4)
        {
            print("scenario 4");
            //white on A  //wiretype 4
            //black on C
            if (wire1.GetComponent<MeshRenderer>().material.color == Color.black
                && wire1.GetComponent<WireType>().TheWireType == 4
                && wire2.GetComponent<MeshRenderer>().material.color == Color.white
                && wire2.GetComponent<WireType>().TheWireType == 4
                ||
                wire7.GetComponent<MeshRenderer>().material.color == Color.black
                && wire7.GetComponent<WireType>().TheWireType == 4
                && wire8.GetComponent<MeshRenderer>().material.color == Color.white
                && wire8.GetComponent<WireType>().TheWireType == 4
                ||
                wire10.GetComponent<MeshRenderer>().material.color == Color.black
                && wire10.GetComponent<WireType>().TheWireType == 4
                && wire9.GetComponent<MeshRenderer>().material.color == Color.white
                && wire9.GetComponent<WireType>().TheWireType == 4
                ||
                wire16.GetComponent<MeshRenderer>().material.color == Color.black
                && wire16.GetComponent<WireType>().TheWireType == 4
                && wire15.GetComponent<MeshRenderer>().material.color == Color.white
                && wire15.GetComponent<WireType>().TheWireType == 4)
            {
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 5)
        {
            print("scenario 5");
            //red on A   type 4
            //blue on B
            if (wire6.GetComponent<MeshRenderer>().material.color == Color.red
                && wire6.GetComponent<WireType>().TheWireType == 4
                && wire5.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire5.GetComponent<WireType>().TheWireType == 4
                ||
                wire11.GetComponent<MeshRenderer>().material.color == Color.red
                && wire11.GetComponent<WireType>().TheWireType == 4
                && wire12.GetComponent<MeshRenderer>().material.color == Color.blue
                && wire12.GetComponent<WireType>().TheWireType == 4)
            {
                print("correct!");
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                print("NOT correct!");
                IncorrectEndElectricalGameScript.EndGame();
            }

        }


        if (DontDestroy.ScenarioCounter == 6)
        {
            print("scenario 6");
            //white on A   type 4
            //black on B
            if (wire6.GetComponent<MeshRenderer>().material.color == Color.white
                && wire6.GetComponent<WireType>().TheWireType == 4
                && wire5.GetComponent<MeshRenderer>().material.color == Color.black
                && wire5.GetComponent<WireType>().TheWireType == 4
                ||
                wire11.GetComponent<MeshRenderer>().material.color == Color.white
                && wire11.GetComponent<WireType>().TheWireType == 4
                && wire12.GetComponent<MeshRenderer>().material.color == Color.black
                && wire12.GetComponent<WireType>().TheWireType == 4)
            {
                print("correct!");
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                print("NOT correct!");
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 7)
        {
            print("scenario 7");
            //white on A  //wiretype 2
            //black on C
            if (wire1.GetComponent<MeshRenderer>().material.color == Color.black
                && wire1.GetComponent<WireType>().TheWireType == 2
                && wire2.GetComponent<MeshRenderer>().material.color == Color.white
                && wire2.GetComponent<WireType>().TheWireType == 2
                ||
                wire7.GetComponent<MeshRenderer>().material.color == Color.black
                && wire7.GetComponent<WireType>().TheWireType == 2
                && wire8.GetComponent<MeshRenderer>().material.color == Color.white
                && wire8.GetComponent<WireType>().TheWireType == 2
                ||
                wire10.GetComponent<MeshRenderer>().material.color == Color.black
                && wire10.GetComponent<WireType>().TheWireType == 2
                && wire9.GetComponent<MeshRenderer>().material.color == Color.white
                && wire9.GetComponent<WireType>().TheWireType == 2
                ||
                wire16.GetComponent<MeshRenderer>().material.color == Color.black
                && wire16.GetComponent<WireType>().TheWireType == 2
                && wire15.GetComponent<MeshRenderer>().material.color == Color.white
                && wire15.GetComponent<WireType>().TheWireType == 2)
            {
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                IncorrectEndElectricalGameScript.EndGame();
            }

        }

        if (DontDestroy.ScenarioCounter == 8)
        {
            print("scenario 8");
            //black on A  //wiretype 2
            //white on C
            if (wire1.GetComponent<MeshRenderer>().material.color == Color.white
                && wire1.GetComponent<WireType>().TheWireType == 2
                && wire2.GetComponent<MeshRenderer>().material.color == Color.black
                && wire2.GetComponent<WireType>().TheWireType == 2
                ||
                wire7.GetComponent<MeshRenderer>().material.color == Color.white
                && wire7.GetComponent<WireType>().TheWireType == 2
                && wire8.GetComponent<MeshRenderer>().material.color == Color.black
                && wire8.GetComponent<WireType>().TheWireType == 2
                ||
                wire10.GetComponent<MeshRenderer>().material.color == Color.white
                && wire10.GetComponent<WireType>().TheWireType == 2
                && wire9.GetComponent<MeshRenderer>().material.color == Color.black
                && wire9.GetComponent<WireType>().TheWireType == 2
                ||
                wire16.GetComponent<MeshRenderer>().material.color == Color.white
                && wire16.GetComponent<WireType>().TheWireType == 2
                && wire15.GetComponent<MeshRenderer>().material.color == Color.black
                && wire15.GetComponent<WireType>().TheWireType == 2)
            {
                CorrectElectricalGameScript.CorrectAnswer();
            }
            else
            {
                IncorrectEndElectricalGameScript.EndGame();
            }

        }


    }
}
