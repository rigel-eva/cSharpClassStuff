using System;
using System.Collections.Generic;
class conwayCell{
  public enum cellStatus{alive, dead, dying, birthing};//All possible states of a cell
  private List<conwayCell> neighbors;//Our Neighbors
  private bool _alive;//Whether or not the cell is alive
  public bool alive{
    get{
      return _alive;
    }
    private set{
      _alive=value;
    }
  }
  public cellStatus status{
    get{
			bool nextStep = isAliveNextStep();
	      if(alive&&nextStep){
	        return cellStatus.alive;
	      }
	      else if(!alive&&nextStep){
	        return cellStatus.birthing;
	      } else if(alive&&!nextStep){
	        return cellStatus.dying;
	      }
	      else{
	        return cellStatus.dying;
	      }
    }
  }
  public conwayCell(){
		neighbors = new List<conwayCell>();
		alive=false;
  }
  public conwayCell(bool alive){
    this.alive=alive;
  }
  public void addNeighbor(conwayCell neighbor){
		this.neighbors.add(neighbor);
  }
  private bool isAliveNextStep(){
    int livingCells=0;
		for (int i = 0; i < neighbors.Count; i++)
		{
			if (neighbors[i].alive)
			{
				livingCells++;
			}
		}
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
  public void step(){
    alive=isAliveNextStep();
  }

}
