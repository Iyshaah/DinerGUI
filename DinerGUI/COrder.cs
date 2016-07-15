using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerGUI 
{
    //business logic
    //defines a template for a food order OBJECT
    //includes behaviours for processing an order that includes selections for (1) entrée  (2) drinks (3) and special requests
    //class COrder assigns prices to each item selected and determines the overall price of the order

    class COrder
    {
        String entrée;
        private bool waterRequested = false;//data field member
        private bool drinkRequested = false; //data field member       
        private String specialRequests;//data field member
        private Decimal entréePrice;//data field member
        private Decimal drinkPrice;//data field member

//TWO private members
      private int doors;//member
      private String engine;//member

      //ONE constructor
      //no BLANK constructors allowed bc the SUPER CVehicle itself doesn't have a blank constructor
      public COrder(int numDoors, String engineSize)   
        {
          int doors=numDoors;
          String engine=engineSize;
        }
   
    //TWO getters 
    public int getNumDoors() 
    {
        return doors;
    }
    public String getEngineSize()
    {
        return engine;
    }

    //TWO setters 
    public void setNumDoors(int numDoors) 
    {        
     doors=numDoors;
    }
    public void setEngineSize(String engineSize) 
    {        
     engine=engineSize;
    }

    ////TWO public methods
    //Override
    //public String toString()//public method
    //{
        //    return "COrder Class:  Diner by the Valley campus deli;  \nBeta Version 1.0;  March 4th, 2015";
    //}
    //Override 
    //public int vehicleGo(int distance)//public method
    //{
    //  return distance;
    //}







    }
}
