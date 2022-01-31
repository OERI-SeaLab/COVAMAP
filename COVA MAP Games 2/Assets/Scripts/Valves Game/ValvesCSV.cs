using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ValvesCSV : MonoBehaviour
{
	public TextAsset csv;

	public GameObject AboutValveText;
	public GameObject AboutValvePanel;

	public List<string> DescriptionsList;

	public List<GameObject> DropHereList1;
	public List<GameObject> DropHereList2;
	public List<GameObject> DropHereList3;
	public List<GameObject> DropHereList4;

	public List<GameObject> DropHereList;

	public List<GameObject> ValveSpotsList1;
	public List<GameObject> ValveSpotsList2;
	public List<GameObject> ValveSpotsList3;
	public List<GameObject> ValveSpotsList4;

	public List<GameObject> ValveSpotsList;

	public List<GameObject> ActualValveList1;
	public List<GameObject> ActualValveList2;
	public List<GameObject> ActualValveList3;
	public List<GameObject> ActualValveList4;

	public List<GameObject> ActualValveList;

	public string CurrectValveDescription;

	public int indexValve = 0;

	public int index = 0;

	public GameObject CheckButtonPanel;

	public GameObject NextButtonPanel;

	public ShowCorrectScenario ShowCorrectScenarioScript; 


	//Read in the csv.
	void Start()
	{
		DropHereList.Clear();
		ValveSpotsList.Clear();
		ActualValveList.Clear();



		if (DontDestroy.BeenThroughFirstValveScenario == false)
		{

			Load(csv);

			if (DontDestroy.ScenarioChoice == "1")
			{
				DropHereList = DropHereList1;
				ValveSpotsList = ValveSpotsList1;
				ActualValveList = ActualValveList1;
			}

			foreach (var x in ActualValveList)
			{
				x.SetActive(false);
			}

			foreach (var x in ValveSpotsList)
			{
				x.GetComponent<Collider>().enabled = false;
			}

			foreach (var x in DropHereList)
			{
				x.SetActive(false);
			}

			DontDestroy.ScenarioCounter = 0;

			AboutValveText.GetComponent<Text>().text = DescriptionsList[index];

			ValveSpotsList[indexValve].GetComponent<Collider>().enabled = true;
			DropHereList[indexValve].SetActive(true);

			CheckButtonPanel.SetActive(false);
			NextButtonPanel.SetActive(false);

			DontDestroy.BeenThroughFirstValveScenario = true;

			ShowCorrectScenarioScript.DisplayCorrectScenario();

		}
		else
		{

			DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);   //Remove the used scenario.

			if (DontDestroy.ScenarioList.Count == 0)   //If there are no scenarios left, hide the next scenario button.
			{
				print("No new scenarios");
				//NewScenarioButtonPanel.SetActive(false);
			}

			else
			{
				index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);  //Randomly choose a scenario.

				DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

				print("Scenario Choice: " + DontDestroy.ScenarioChoice);

				if (DontDestroy.ScenarioChoice == "1")
				{
					ValveSpotsList = ValveSpotsList1;
					ActualValveList = ActualValveList1;
					DropHereList = DropHereList1;
				}

				if (DontDestroy.ScenarioChoice == "2")
				{
					ValveSpotsList = ValveSpotsList2;
					ActualValveList = ActualValveList2;
					DropHereList = DropHereList2;
				}

				if (DontDestroy.ScenarioChoice == "3")
				{
					ValveSpotsList = ValveSpotsList3;
					ActualValveList = ActualValveList3;
					DropHereList = DropHereList3;
				}

				if (DontDestroy.ScenarioChoice == "4")
				{
					ValveSpotsList = ValveSpotsList4;
					ActualValveList = ActualValveList4;
					DropHereList = DropHereList4;
				}

				foreach (var x in ActualValveList)
				{
					x.SetActive(false);
				}

				foreach (var x in DropHereList)
				{
					x.SetActive(false);
				}

				foreach (var x in ValveSpotsList)
				{
					x.GetComponent<Collider>().enabled = false;
				}

				Load(csv);

				print("Length" + DescriptionsList.Count);
				foreach (var x in DescriptionsList)
				{
					print("before: " + x);
				}

				//Save about game info.
				DontDestroy.AboutGameText = Find_Scenario(DontDestroy.ScenarioChoice).MainGameDescription;

				//Save instructions info.
				DontDestroy.InstructionsText = Find_Scenario(DontDestroy.ScenarioChoice).MainScenarioDescription;

				DontDestroy.NumberOfValves = Find_Scenario(DontDestroy.ScenarioChoice).NumberOfValves;

				AboutValveText.GetComponent<Text>().text = DescriptionsList[index];

				ValveSpotsList[indexValve].GetComponent<Collider>().enabled = true;

				DropHereList[indexValve].SetActive(true);

				CheckButtonPanel.SetActive(false);
				NextButtonPanel.SetActive(false);

				ShowCorrectScenarioScript.DisplayCorrectScenario();
			}

		}

	}

	public void DisplayCorrectValveDescription()
	{
		DropHereList[indexValve].SetActive(false);
		
		indexValve = indexValve + 1;


		if (indexValve < System.Convert.ToInt32(DontDestroy.NumberOfValves))
		{
			AboutValveText.GetComponent<Text>().text = DescriptionsList[indexValve];

			ValveSpotsList[indexValve].GetComponent<Collider>().enabled = true;
			DropHereList[indexValve].SetActive(true);
		}
		else
        {
			print("end");
			AboutValvePanel.SetActive(false);

			CheckButtonPanel.SetActive(true);
			//NextButtonPanel.SetActive(true);
		}

		print(indexValve);
	}


	public class Row
	{
		public string Scenario;
		public string NumberOfValves;
		public string MainGameDescription;
		public string MainScenarioDescription;
		public string ValveOneDescription;
		public string ValveOne;
		public string ValveOneRotation;
		public string ValveTwoDescription;
		public string ValveTwo;
		public string ValveTwoRotation;
		public string ValveThreeDescription;
		public string ValveThree;
		public string ValveThreeRotation;
		public string ValveFourDescription;
		public string ValveFour;
		public string ValveFourRotation;
		public string ValveFiveDescription;
		public string ValveFive;
		public string ValveFiveRotation;

	}

	List<Row> rowList = new List<Row>();
	bool isLoaded = false;

	public bool IsLoaded()
	{
		return isLoaded;
	}

	public List<Row> GetRowList()
	{
		return rowList;
	}

	public void Load(TextAsset csv)
	{
		rowList.Clear();
		string[][] grid = CsvParser2.Parse(csv.text);
		for (int i = 1; i < grid.Length; i++)
		{
			Row row = new Row();
			row.Scenario = grid[i][0];
			row.NumberOfValves = grid[i][1];
			row.MainGameDescription = grid[i][2];
			row.MainScenarioDescription = grid[i][3];
			row.ValveOneDescription = grid[i][4];
			row.ValveOne = grid[i][5];
			row.ValveOneRotation = grid[i][6];
			row.ValveTwoDescription = grid[i][7];
			row.ValveTwo = grid[i][8];
			row.ValveTwoRotation = grid[i][9];
			row.ValveThreeDescription = grid[i][10];
			row.ValveThree = grid[i][11];
			row.ValveThreeRotation = grid[i][12];
			row.ValveFourDescription = grid[i][13];
			row.ValveFour = grid[i][14];
			row.ValveFourRotation = grid[i][15];
			row.ValveFiveDescription = grid[i][16];
			row.ValveFive = grid[i][17];
			row.ValveFiveRotation = grid[i][18];


			rowList.Add(row);

        }
	
		DescriptionsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).ValveOneDescription);
		DescriptionsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).ValveTwoDescription);
		DescriptionsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).ValveThreeDescription);
		DescriptionsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).ValveFourDescription);
		DescriptionsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).ValveFiveDescription);

		isLoaded = true;
	}

	public int NumRows()
	{
		return rowList.Count;
	}

	public Row GetAt(int i)
	{
		if (rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public Row Find_Scenario(string find)
	{
		return rowList.Find(x => x.Scenario == find);
	}
	public List<Row> FindAll_Scenario(string find)
	{
		return rowList.FindAll(x => x.Scenario == find);
	}
	public Row Find_NumberOfValves(string find)
	{
		return rowList.Find(x => x.NumberOfValves == find);
	}
	public List<Row> FindAll_NumberOfValves(string find)
	{
		return rowList.FindAll(x => x.NumberOfValves == find);
	}
	public Row Find_MainGameDescription(string find)
	{
		return rowList.Find(x => x.MainGameDescription == find);
	}
	public List<Row> FindAll_MainGameDescription(string find)
	{
		return rowList.FindAll(x => x.MainGameDescription == find);
	}
	public Row Find_MainScenarioDescription(string find)
	{
		return rowList.Find(x => x.MainScenarioDescription == find);
	}
	public List<Row> FindAll_MainScenarioDescription(string find)
	{
		return rowList.FindAll(x => x.MainScenarioDescription == find);
	}
	public Row Find_ValveOneDescription(string find)
	{
		return rowList.Find(x => x.ValveOneDescription == find);
	}
	public List<Row> FindAll_ValveOneDescription(string find)
	{
		return rowList.FindAll(x => x.ValveOneDescription == find);
	}
	public Row Find_ValveOne(string find)
	{
		return rowList.Find(x => x.ValveOne == find);
	}
	public List<Row> FindAll_ValveOne(string find)
	{
		return rowList.FindAll(x => x.ValveOne == find);
	}
	public Row Find_ValveOneRotation(string find)
	{
		return rowList.Find(x => x.ValveOneRotation == find);
	}
	public List<Row> FindAll_ValveOneRotation(string find)
	{
		return rowList.FindAll(x => x.ValveOneRotation == find);
	}
	public Row Find_ValveTwoDescription(string find)
	{
		return rowList.Find(x => x.ValveTwoDescription == find);
	}
	public List<Row> FindAll_ValveTwoDescription(string find)
	{
		return rowList.FindAll(x => x.ValveTwoDescription == find);
	}
	public Row Find_ValveTwo(string find)
	{
		return rowList.Find(x => x.ValveTwo == find);
	}
	public List<Row> FindAll_ValveTwo(string find)
	{
		return rowList.FindAll(x => x.ValveTwo == find);
	}
	public Row Find_ValveTwoRotation(string find)
	{
		return rowList.Find(x => x.ValveTwoRotation == find);
	}
	public List<Row> FindAll_ValveTwoRotation(string find)
	{
		return rowList.FindAll(x => x.ValveTwoRotation == find);
	}
	public Row Find_ValveThreeDescription(string find)
	{
		return rowList.Find(x => x.ValveThreeDescription == find);
	}
	public List<Row> FindAll_ValveThreeDescription(string find)
	{
		return rowList.FindAll(x => x.ValveThreeDescription == find);
	}
	public Row Find_ValveThree(string find)
	{
		return rowList.Find(x => x.ValveThree == find);
	}
	public List<Row> FindAll_ValveThree(string find)
	{
		return rowList.FindAll(x => x.ValveThree == find);
	}
	public Row Find_ValveThreeRotation(string find)
	{
		return rowList.Find(x => x.ValveThreeRotation == find);
	}
	public List<Row> FindAll_ValveThreeRotation(string find)
	{
		return rowList.FindAll(x => x.ValveThreeRotation == find);
	}
	public Row Find_ValveFourDescription(string find)
	{
		return rowList.Find(x => x.ValveFourDescription == find);
	}
	public List<Row> FindAll_ValveFourDescription(string find)
	{
		return rowList.FindAll(x => x.ValveFourDescription == find);
	}
	public Row Find_ValveFour(string find)
	{
		return rowList.Find(x => x.ValveFour == find);
	}
	public List<Row> FindAll_ValveFour(string find)
	{
		return rowList.FindAll(x => x.ValveFour == find);
	}
	public Row Find_ValveFourRotation(string find)
	{
		return rowList.Find(x => x.ValveFourRotation == find);
	}
	public List<Row> FindAll_ValveFourRotation(string find)
	{
		return rowList.FindAll(x => x.ValveFourRotation == find);
	}
	public Row Find_ValveFiveDescription(string find)
	{
		return rowList.Find(x => x.ValveFiveDescription == find);
	}
	public List<Row> FindAll_ValveFiveDescription(string find)
	{
		return rowList.FindAll(x => x.ValveFiveDescription == find);
	}
	public Row Find_ValveFive(string find)
	{
		return rowList.Find(x => x.ValveFive == find);
	}
	public List<Row> FindAll_ValveFive(string find)
	{
		return rowList.FindAll(x => x.ValveFive == find);
	}
	public Row Find_ValveFiveRotation(string find)
	{
		return rowList.Find(x => x.ValveFiveRotation == find);
	}
	public List<Row> FindAll_ValveFiveRotation(string find)
	{
		return rowList.FindAll(x => x.ValveFiveRotation == find);
	}

}
