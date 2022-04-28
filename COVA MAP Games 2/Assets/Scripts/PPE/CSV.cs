using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSV : MonoBehaviour
{
   // Load csv.
	
	public TextAsset csv;

	private int index;

    //Read in the csv.
    void Start()
    {

        Load(csv);
		

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

	static List<Row> rowList = new List<Row>();
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
			//DontDestroy.ScenarioList.Add(row.id);

			/////////////
			//DontDestroy.InstructionsList.Add(row.instructions);
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

	static public Row Find_id(string find)
	{
		return rowList.Find(x => x.id == find);
	}

}
