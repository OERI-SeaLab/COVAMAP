using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PickSenarioHazards : MonoBehaviour
{
	public TextAsset csv;

	private int index;

	public GameObject AboutText;

	//Read in the csv.
	public void Start()
	{
		DontDestroy.ScenarioList.Clear();
		DontDestroy.CorrectHazardsList.Clear();

		Load(csv);
		index = 0;
		
		DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];
		DontDestroy.InstructionsText = DontDestroy.InstructionsList[index];

		Debug.Log("Scenario Choice: " + DontDestroy.ScenarioChoice);

		//Save about game info.
		DontDestroy.AboutGameText = Find_Scenario(DontDestroy.ScenarioChoice).MainGameDescription;

		//DontDestroy.NumberOfValves = Find_Scenario(DontDestroy.ScenarioChoice).NumberOfValves;


		AboutText.GetComponent<Text>().text = DontDestroy.AboutGameText;

		DontDestroy.BeenThroughFirstValveScenario = false;

		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard1);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard2);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard3);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard4);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard5);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard6);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard7);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard8);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard9);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard10);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard11);
		DontDestroy.CorrectHazardsList.Add(Find_Scenario(DontDestroy.ScenarioChoice).Hazard12);

	}

		public class Row
		{
			public string Scenario;
			public string MainGameDescription;
			public string Hazard1;
			public string Hazard2;
			public string Hazard3;
			public string Hazard4;
			public string Hazard5;
			public string Hazard6;
			public string Hazard7;
			public string Hazard8;
			public string Hazard9;
			public string Hazard10;
			public string Hazard11;
			public string Hazard12;

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
				row.MainGameDescription = grid[i][1];
				row.Hazard1 = grid[i][2];
				row.Hazard2 = grid[i][3];
				row.Hazard3 = grid[i][4];
				row.Hazard4 = grid[i][5];
				row.Hazard5 = grid[i][6];
				row.Hazard6 = grid[i][7];
				row.Hazard7 = grid[i][8];
				row.Hazard8 = grid[i][9];
				row.Hazard9 = grid[i][10];
				row.Hazard10 = grid[i][11];
				row.Hazard11 = grid[i][12];
				row.Hazard12 = grid[i][13];


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
		public Row Find_MainGameDescription(string find)
		{
			return rowList.Find(x => x.MainGameDescription == find);
		}
		public List<Row> FindAll_MainGameDescription(string find)
		{
			return rowList.FindAll(x => x.MainGameDescription == find);
		}
		public Row Find_Hazard1(string find)
	{
		return rowList.Find(x => x.Hazard1 == find);
	}
	public List<Row> FindAll_Hazard1(string find)
	{
		return rowList.FindAll(x => x.Hazard1 == find);
	}
public Row Find_Hazard2(string find)
	{
	return rowList.Find(x => x.Hazard2 == find);
}
public List<Row> FindAll_Hazard2(string find)
	{
	return rowList.FindAll(x => x.Hazard2 == find);
}
public Row Find_Hazard3(string find)
	{
	return rowList.Find(x => x.Hazard3 == find);
}
public List<Row> FindAll_Hazard3(string find)
	{
	return rowList.FindAll(x => x.Hazard3 == find);
}
public Row Find_Hazard4(string find)
	{
	return rowList.Find(x => x.Hazard4 == find);
}
public List<Row> FindAll_Hazard4(string find)
	{
	return rowList.FindAll(x => x.Hazard4 == find);
}
public Row Find_Hazard5(string find)
	{
	return rowList.Find(x => x.Hazard5 == find);
}
public List<Row> FindAll_Hazard5(string find)
	{
	return rowList.FindAll(x => x.Hazard5 == find);
}
public Row Find_Hazard6(string find)
	{
	return rowList.Find(x => x.Hazard6 == find);
}
public List<Row> FindAll_Hazard6(string find)
	{
	return rowList.FindAll(x => x.Hazard6 == find);
}
public Row Find_Hazard7(string find)
	{
	return rowList.Find(x => x.Hazard7 == find);
}
public List<Row> FindAll_Hazard7(string find)
	{
	return rowList.FindAll(x => x.Hazard7 == find);
}
public Row Find_Hazard8(string find)
	{
	return rowList.Find(x => x.Hazard8 == find);
}
public List<Row> FindAll_Hazard8(string find)
	{
	return rowList.FindAll(x => x.Hazard8 == find);
}
public Row Find_Hazard9(string find)
	{
	return rowList.Find(x => x.Hazard9 == find);
}
public List<Row> FindAll_Hazard9(string find)
	{
	return rowList.FindAll(x => x.Hazard9 == find);
}
public Row Find_Hazard10(string find)
	{
	return rowList.Find(x => x.Hazard10 == find);
}
public List<Row> FindAll_Hazard10(string find)
	{
	return rowList.FindAll(x => x.Hazard10 == find);
}
public Row Find_Hazard11(string find)
	{
	return rowList.Find(x => x.Hazard11 == find);
}
public List<Row> FindAll_Hazard11(string find)
	{
	return rowList.FindAll(x => x.Hazard11 == find);
}
public Row Find_Hazard12(string find)
	{
	return rowList.Find(x => x.Hazard12 == find);
}
public List<Row> FindAll_Hazard12(string find)
	{
	return rowList.FindAll(x => x.Hazard12 == find);
}

}
