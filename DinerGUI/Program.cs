using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUI
{
    //event driven application that includes the design and implementation of a graphical user interface

    static class Program
    {
        //Diner by the Valley campus deli
        //
        //CAMPUS CENTER ORDER-TAKER
        //
        //Menu sandwichOptions
        //Menu drinkOptions
        //
        //PREFERENCES FOR WATER
        //boolean checkboxWaterRequested
        //
        //white bread
        //
        //Menu special selection
        //wholeWheatBread
        //ryeBread
        //
        //Menu Special Requests - Hold the "x"
        //boolean noOnion
        //boolean noMayo
        //boolean noCheese
        //boolean noDressing
        //
        //INPUT = entrée selections
        //INPUT = drink selections
        //
        //OUTPUT = TOTAL COST of Order
        //OUTPUT = Display current order selections
        //
        //ALLOW STUDENTS THE OPTION TO CHANGE THEIR MINDS ABOUT EACH OF THE SELECTIONS
        //
        //

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Diner by the Valley campus deli
            //
            //CAMPUS CENTER ORDER-TAKER

            String entrée;
            //Menu sandwichOptions

            bool waterRequested = false;
            bool drinkRequested = false;
            //Menu drinkOptions
            //PREFERENCES FOR WATER
            
            String specialRequests;
            //Menu Special Requests
            //boolean noOnion
            //boolean noMayo
            //boolean noCheese

            //white bread
            //Menu special selection
            //wholeWheatBread
            //ryeBread

//Chicken Salad
//Ham and Cheese
//Turkey 
//Vegetable Wrap
//Tuna Salad
//Avocado and Cheese 
//Club
//Peanut Butter & Jelly
//Grilled Cheese
//Reuben

            //INPUT = entree selections
            //INPUT = drink selections

            Decimal entréePrice;
            Decimal drinkPrice;
            //OUTPUT = TOTAL COST of Order
            //OUTPUT = Display current order selections
            //
            //ALLOW STUDENTS THE OPTION TO CHANGE THEIR MINDS ABOUT EACH OF THE SELECTIONS

        }
    }
}
