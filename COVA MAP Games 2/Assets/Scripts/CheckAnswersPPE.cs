using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckAnswersPPE: MonoBehaviour
{
    public Dress DressScript;     //Referencing other scripts.
    public DestroyAllChildren DestroyAllChildrenScript;

    public List<GameObject> CheckList = new List<GameObject>();     //Initialize CheckList, the list of answers the user chose.

    private int NumObjectsCheck;     //The number of all avaible answers.

    public GameObject CorrectIncorrectPrefab;    //The check marks and x's prefabs that are instantiated when the user clicks check and/or time runs out.

    public GameObject Panel;     //The parent panel where all the instatiated check marks and x's will appear. Allows for them all to be deleted when the user presses check again.

    public int NumberTimesChecked = 0;    //Important to keep track of the number of times checked to calculate the score. Score is reduced each time the user hits check beyond the first time.

    public GameObject PointDeduction;

    public AudioSource Wrong;


    //Checks the active images (DressScript.check or the CheckList) against the correct answers (DontDestroy.CorrectList).
    public void Start()
    {
        PointDeduction.SetActive(false);
    }
    public void CheckingAnswers()
    {
        DestroyAllChildrenScript.DestroyChildren();       //Calls for all the children (check marks and x's) to be deleted. Will not delete anything until check button is clicked a second time.
        CheckList.Clear();      //Clears the list of user answers.
        DontDestroy.NumberCorrect = 0;      //Number correct starts at zero.

        NumberTimesChecked = NumberTimesChecked + 1;    //Adds one to the number of times checked each time the checked button is clicked or the time runs out.
        
        for(int i = 0; i < DressScript.NumObjects; i++)    //Adds the users answers (the active images) to the CheckList.
        {
            if(DressScript.check[i].activeInHierarchy == true)
            {
                CheckList.Add(DressScript.check[i]);
            }
        }
        
        for(int i = 0 ; i < CheckList.Count ; i++)     //Go through the Clicklist, compare to the CorrectList. 
        {
            GameObject CorrectIndicator;
            GameObject IncorrectIndicator;
            //var destroyTime = 1;

            if(DontDestroy.CorrectList.Contains(CheckList[i].name))    //If the user answer is on the correct list, assign the prefab correct (check mark). 
            {
                //Debug.Log("match");
                CorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);    //Place prefab in the location of the item on ClickList's parent.
                CorrectIndicator.GetComponent<CorrectIncorect>().AssignCorrect();  //assign the prefab correct (check mark). 
                CorrectIndicator.transform.SetParent(Panel.transform, false);
                DontDestroy.NumberCorrect = DontDestroy.NumberCorrect + 1;
                Debug.Log("Number Correct: " + DontDestroy.NumberCorrect + " Number of Times Checked: " + NumberTimesChecked);
            }
            else   //If the user answer is NOT on the correct list, assign the prefab incorrect (x).
            {
                //Debug.Log("not matching");
                IncorrectIndicator = Instantiate(CorrectIncorrectPrefab, CheckList[i].transform.parent.localPosition, Quaternion.identity);    //Place prefab in the location of the item on ClickList's parent.
                IncorrectIndicator.GetComponent<CorrectIncorect>().AssignIncorrect(); //assign the prefab incorrect (x).
                IncorrectIndicator.transform.SetParent(Panel.transform, false);
                if(DontDestroy.timeLeft>0.0f && NumberTimesChecked>1)
                {
                    PointDeduction.SetActive(true);
                    Wrong.Play();
                }
                StartCoroutine(HideX(IncorrectIndicator));
            } 
        }
    }
    //After 2 seconds of being displayed, destroy the x's.
    public IEnumerator HideX(GameObject x)
    {
        yield return new WaitForSeconds(2);
        Destroy(x);
        PointDeduction.SetActive(false);

        //Debug.Log("got here");
    }
}
    
