using Godot;
using System;
using System.Collections.Generic;

public partial class TileMapGen : TileMapLayer
{
	private Dictionary<string, int> tileTypeToId = new Dictionary<string, int>
	{
		{"grass", 0},
		{"sand", 1},
		{"water", 2},
		{"path", 3}
	};
	
	private List<Vector2I> atlasCoords = new List<Vector2I>
	{
		new Vector2I(0, 0),
		new Vector2I(1, 1),
		new Vector2I(0, 1),
		new Vector2I(1, 0)
	};

	public override void _Ready()
	{
		List<Tile> allTiles = new List<Tile>
		{
			new Tile("grass", new List<string> {"grass", "sand", "path", "water"}),
			new Tile("sand", new List<string> {"sand", "grass", "water"}),
			new Tile("water", new List<string> {"sand", "grass"}),
			new Tile("path", new List<string> {"grass", "path"})
		};

		Grid grid = new Grid(100, 50, allTiles);
		WFC wfc = new WFC(grid);
		wfc.Collapse();

		DrawTiles(grid);
	}

	private void DrawTiles(Grid grid)
	{
		for (int x = 0; x < grid.Width; x++)
		{
			for (int y = 0; y < grid.Height; y++)
			{
				Tile tile = grid.Cells[x, y][0];
				DrawTile(x, y, tile);
			}
		}
	}

	private void DrawTile(int x, int y, Tile tile)
	{
		if (tileTypeToId.ContainsKey(tile.Type))
		{
			int tileId = tileTypeToId[tile.Type];
			SetCell(new Vector2I(x, y), 0, atlasCoords[tileId]);
		} 
		else
		{
			GD.PrintErr($"Unkown tile type: {tile.Type}");
		}
	}
}
public class Tile 
{
	public string Type;
	public List<string> AllowedNeighbors;

	public Tile(string type, List<string> allowedNeighbors) 
	{
		Type = type;
		AllowedNeighbors = allowedNeighbors;
	}
}

public class Grid
{
	public int Width { get; }
	public int Height { get; }
	public List<Tile>[,] Cells;

	public Grid(int width, int height, List<Tile> allTiles)
	{
		Width = width;
		Height = height;
		Cells = new List<Tile>[Width, Height];

		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				Cells[x, y] = new List<Tile>(allTiles);
			}
		}
	}

}

public class WFC
{
	private Grid grid;
	private Random random = new Random();

	public WFC(Grid grid)
	{
		this.grid = grid;
	}

	public void Collapse()
	{
		while (!(IsFullyCollapsed()))
		{
			var cell = GetLowestEntropyCell();
			if (cell == null)
				break;

			CollapseCell(cell.Value);
			Propagate(cell.Value);
		}
	}

	private (int x, int y)? GetLowestEntropyCell()
	{
		int minEntropy = int.MaxValue;
		(int x, int y)? lowestEntropyCell = null;

		for (int x = 0; x < grid.Width; x++)
		{
			for (int y = 0; y < grid.Height; y++)
			{
				var possibleTiles = grid.Cells[x, y];
				int entropy = possibleTiles.Count;

				if (entropy > 1 && entropy < minEntropy)
				{
					minEntropy = entropy;
					lowestEntropyCell = (x, y);
				}
			}
		}

		return lowestEntropyCell;
	}

	private void CollapseCell((int x, int y) cell)
	{
		var (x, y) = cell;
		var possibleTiles = grid.Cells[x, y];

		var selectedTile = possibleTiles[random.Next(possibleTiles.Count)];
		grid.Cells[x, y] = new List<Tile> {selectedTile};
	}

	private void Propagate((int x, int y) cell)
	{
		var q = new Queue<(int x, int y)>();
		q.Enqueue(cell);

		while (q.Count > 0)
		{
			var (x, y) = q.Dequeue();
Console.WriteLine(grid.Cells[x, y].Count);
			var currentTile = grid.Cells[x, y][0];
			
			var neighbors = GetNeighbors(x, y);
			foreach (var (nx, ny) in neighbors)
			{
				var possibleTiles = grid.Cells[nx, ny];
				int originalCount = possibleTiles.Count;
//Console.WriteLine(nx + "==" + ny);
				possibleTiles.RemoveAll(tile => !tile.AllowedNeighbors.Contains(currentTile.Type));

				if (possibleTiles.Count != originalCount)
				{
					q.Enqueue((nx, ny));
				}
			}
		}
	}

	private List<(int x, int y)> GetNeighbors(int x, int y)
	{
		var neighbors = new List<(int x, int y)>();

		if (x > 0) 
			neighbors.Add((x - 1, y));
		if (x < grid.Width - 1) 
			neighbors.Add((x + 1, y));
		if (y > 0) 
			neighbors.Add((x, y - 1));
		if (y < grid.Height - 1)
			neighbors.Add((x, y + 1));
		//foreach (var (nx, ny) in neighbors)
		//	Console.WriteLine(nx + "==" + ny);

		return neighbors;
	}

	private bool IsFullyCollapsed()
	{
		for (int x = 0; x < grid.Width; x++)
		{
			for (int y = 0; y < grid.Height; y++)
			{
				if (grid.Cells[x, y].Count > 1)
					return false;
			}
		}

		return true;
	}
}
