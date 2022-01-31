using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickScenario : MonoBehaviour
{
    public TextAsset csv;

	private int index;

    public GameObject AboutText;

    //Read in the csv.
    void Start()
    {

        Load(csv);

		DontDestroy.ScenarioCounter = 0;

		if (DontDestroy.GameChoice == "PPE")
		{
			index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);  //Randomly choose a scenario.
		}

		DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];

        Debug.Log(DontDestroy.ScenarioChoice);

        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).head);    //Create CheckList with the correct answers from the csv.
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).eyes);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).ears);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).face);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).top);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).hands);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).bottom);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).feet);
        DontDestroy.CorrectList.Add(Find_id(DontDestroy.ScenarioChoice).accessories);


        //Save about game info.
        DontDestroy.AboutGameText = Find_id(DontDestroy.ScenarioChoice).about;

        //Save instructions info.
        DontDestroy.InstructionsText = Find_id(DontDestroy.ScenarioChoice).instructions;

		DontDestroy.ScenarioReminderText = Find_id(DontDestroy.ScenarioChoice).scenario;

		AboutText.GetComponent<Text>().text = DontDestroy.AboutGameText;
    }

        public class Row
	{
		public string id;
		public string game;
		public string scenario;
		public string about;
		public string instructions;
		public string head;
		public string eyes;
		public string ears;
		public string face;
		public string top;
		public string hands;
		public string bottom;
		public string feet;
		public string accessories;

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
		for(int i = 1 ; i < grid.Length ; i++)
		{
			Row row = new Row();
			row.id = grid[i][0];
			row.game = grid[i][1];
			row.scenario = grid[i][2];
			row.about = grid[i][3];
			row.instructions = grid[i][4];
			row.head = grid[i][5];
			row.eyes = grid[i][6];
			row.ears = grid[i][7];
			row.face = grid[i][8];
			row.top = grid[i][9];
			row.hands = grid[i][10];
			row.bottom = grid[i][11];
			row.feet = grid[i][12];
			row.accessories = grid[i][13];

			//Create the scenerio list to choose randomly from the available scenarios from the CSV rows.
			DontDestroy.ScenarioList.Add(row.id);

			/////////////
			DontDestroy.InstructionsList.Add(row.instructions);
			/////////////

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
		if(rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public Row Find_id(string find)
	{
		return rowList.Find(x => x.id == find);
	}
	public List<Row> FindAll_id(string find)
	{
		return rowList.FindAll(x => x.id == find);
	}
	public Row Find_game(string find)
	{
		return rowList.Find(x => x.game == find);
	}
	public List<Row> FindAll_game(string find)
	{
		return rowList.FindAll(x => x.game == find);
	}
	public Row Find_scenario(string find)
	{
		return rowList.Find(x => x.scenario == find);
	}
	public List<Row> FindAll_scenario(string find)
	{
		return rowList.FindAll(x => x.scenario == find);
	}
	public Row Find_about(string find)
	{
		return rowList.Find(x => x.about == find);
	}
	public List<Row> FindAll_about(string find)
	{
		return rowList.FindAll(x => x.about == find);
	}
	public Row Find_instructions(string find)
	{
		return rowList.Find(x => x.instructions == find);
	}
	public List<Row> FindAll_instructions(string find)
	{
		return rowList.FindAll(x => x.instructions == find);
	}
	public Row Find_head(string find)
	{
		return rowList.Find(x => x.head == find);
	}
	public List<Row> FindAll_head(string find)
	{
		return rowList.FindAll(x => x.head == find);
	}
	public Row Find_eyes(string find)
	{
		return rowList.Find(x => x.eyes == find);
	}
	public List<Row> FindAll_eyes(string find)
	{
		return rowList.FindAll(x => x.eyes == find);
	}
	public Row Find_ears(string find)
	{
		return rowList.Find(x => x.ears == find);
	}
	public List<Row> FindAll_ears(string find)
	{
		return rowList.FindAll(x => x.ears == find);
	}
	public Row Find_face(string find)
	{
		return rowList.Find(x => x.face == find);
	}
	public List<Row> FindAll_face(string find)
	{
		return rowList.FindAll(x => x.face == find);
	}
	public Row Find_top(string find)
	{
		return rowList.Find(x => x.top == find);
	}
	public List<Row> FindAll_top(string find)
	{
		return rowList.FindAll(x => x.top == find);
	}
	public Row Find_hands(string find)
	{
		return rowList.Find(x => x.hands == find);
	}
	public List<Row> FindAll_hands(string find)
	{
		return rowList.FindAll(x => x.hands == find);
	}
	public Row Find_bottom(string find)
	{
		return rowList.Find(x => x.bottom == find);
	}
	public List<Row> FindAll_bottom(string find)
	{
		return rowList.FindAll(x => x.bottom == find);
	}
	public Row Find_feet(string find)
	{
		return rowList.Find(x => x.feet == find);
	}
	public List<Row> FindAll_feet(string find)
	{
		return rowList.FindAll(x => x.feet == find);
	}
	public Row Find_accessories(string find)
	{
		return rowList.Find(x => x.accessories == find);
	}
	public List<Row> FindAll_accessories(string find)
	{
		return rowList.FindAll(x => x.accessories == find);
	}

}