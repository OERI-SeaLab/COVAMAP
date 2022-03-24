using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScenarioElectrical : MonoBehaviour
{
    public void Start()
    {
        ScenarioImages[1].SetActive(true);
    }

    public GameObject AllScenarioImages;
    public List<GameObject> ScenarioImages = new List<GameObject>();

    // Start is called before the first frame update
    public void NextButtonNextScenario()
    {
        DontDestroy.ScenarioCounter= DontDestroy.ScenarioCounter+1;
        print(DontDestroy.ScenarioCounter);

        AllScenarioImages.SetActive(false);

        if (DontDestroy.ScenarioCounter==1)
        {
            ScenarioImages[1].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 2)
        {
            ScenarioImages[2].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 3)
        {
            ScenarioImages[3].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 4)
        {
            ScenarioImages[4].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 5)
        {
            ScenarioImages[5].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 6)
        {
            ScenarioImages[6].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 7)
        {
            ScenarioImages[7].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 8)
        {
            ScenarioImages[8].SetActive(true);
        }


    }
}
