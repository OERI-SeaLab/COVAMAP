using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PickScenarioValves : MonoBehaviour
{
	public TextAsset csv;

	private int index;

	public GameObject AboutText;

	//Read in the csv.
	void Start()
	{
		DontDestroy.ScenarioList.Clear();
		Load(csv);
		index = 0;
		//index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);  //Randomly choose a scenario.
		DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

		Debug.Log("Scenario Choice:" + DontDestroy.ScenarioChoice);

		//Save about game info.
		DontDestroy.AboutGameText = Find_Scenario(DontDestroy.ScenarioChoice).MainGameDescription;

		DontDestroy.NumberOfValves = Find_Scenario(DontDestroy.ScenarioChoice).NumberOfValves;

		//Save instructions info.
		DontDestroy.InstructionsText = Find_Scenario(DontDestroy.ScenarioChoice).MainScenarioDescription;

		AboutText.GetComponent<Text>().text = DontDestroy.AboutGameText;

		DontDestroy.BeenThroughFirstValveScenario = false;

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


			//Create the scenerio list to choose randomly from the available scenarios from the CSV rows.
			DontDestroy.ScenarioList.Add(row.Scenario);

			/////////////
			DontDestroy.InstructionsList.Add(row.MainGameDescription);

			rowList.Add(row);
		}
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
