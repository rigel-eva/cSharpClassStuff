using System;
using System.Collections.Generic;
class conwayCell
{
	public enum cellStatus { alive, dead, dying, birthing };//All possible states of a cell
	private List<conwayCell> neighbors;//Our Neighbors
	private bool _alive;//Whether or not the cell is alive
	public bool alive
	{
		get
		{
			return _alive;
		}
		private set
		{
			_alive = value;
		}
	}
	public cellStatus status
	{
		get
		{
			bool nextStep = isAliveNextStep();
			if (alive && nextStep)
			{
				return cellStatus.alive;
			}
			else if (!alive && nextStep)
			{
				return cellStatus.birthing;
			}
			else if (alive && !nextStep)
			{
				return cellStatus.dying;
			}
			else {
				return cellStatus.dead;
			}
		}
	}
    #region Constructors
    public conwayCell()
	{
		alive = false;
        neighbors = new List<conwayCell>();
	}
	public conwayCell(bool alive)
	{
		this.alive = alive;
        neighbors = new List<conwayCell>();
    }
    #endregion
    public void addNeighbor(ref conwayCell neighbor)
	{
#warning check here first if something goes a bit screwy ... this should allow us to get constant access to our neighbors state ... but just in case.
        neighbors.Add(neighbor);
	}
	private bool isAliveNextStep()
	{
		int livingCells = 0;
		for (int i = 0; i < neighbors.Count; i++)
		{
			if (neighbors[i].alive)
			{
				livingCells++;
			}
		}
        Console.Write("");
		switch (livingCells)
		{
			case 2://Survival
				return true && alive;//Quick and dirty way to ensure that cells that were dead stay dead.
			case 3://Survival/Birth
				return true;
			case 0://lonelyness
			case 1://lonelyness
			case 4://overpopulation
			case 5://overpopulation
			case 6://overpopulation
			case 7://overpopulation
			case 8://overpopulation
			default:
				return false;
		}
	}
	public void step()
	{
		alive = isAliveNextStep();
	}
    public override string ToString()
    {
        if (alive)
        {
            return "▓";
        }
        else
        {
            return "░";
        }
    }
    public static conwayCell[,] initCells(int width, int height)
	{
		conwayCell[,] returner = new conwayCell[height, width];
		Random rand = new Random();
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
                bool randomBool = rand.NextDouble() >= 0.5;
                returner[i, j]= new conwayCell(randomBool);//Inits a random value
			}
		}
        for (int i = 0; i < width - 1; i++)
        {
            for (int j = 0; j < height - 1; j++)
            {
                addNeighbors(ref returner, j,i);
            }
        }
        return returner;
    }
    private static void addNeighbors(ref conwayCell[,] cellList, int x, int y)
    {
        Console.Write("");
        for (int i = x - 1; i < x + 2; i++)
        {
            for(int j=y-1; j<y+2; j++)
            {
                Console.Write("");
                if (!(i < 0 || i > cellList.GetLength(0)-1 || j < 0 || j > cellList.GetLength(1)-1||(i==x&&j==y)))//As long as we arn't trying to add ourself, or trying to add something out of range ... 
                {
                    cellList[x, y].addNeighbor(ref cellList[i, j]);
                }
           } 
        }
    }
	public static void step(ref conwayCell[,] cells)
	{
		for (int i = 0; i < cells.GetLength(0); i++)
		{
			for (int j = 0; j < cells.GetLength(1); j++)
			{
				cells[i, j].step();
			}
		}
	}
    public static string writeArray(ref conwayCell[,] cells)
    {
        string returner = "";
        for(int i=0; i<cells.GetLength(0); i++)
        {
            for(int j=0; j<cells.GetLength(1); j++)
            {
                returner += cells[i, j];
            }
            returner += "\n";
        }
        returner.TrimEnd('\n');
        return returner;
    }
    public static int currentPopulation(ref conwayCell[,] cells)
    {
        int returner = 0;
        for(int i=0; i<cells.GetLength(0); i++)
        {
            for(int j=0; j<cells.GetLength(1); j++)
            {
                if (cells[i, j].alive)
                {
                    returner++;
                }
            }
        }
        return returner;
    }
}
