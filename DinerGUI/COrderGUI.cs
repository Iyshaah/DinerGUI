using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerGUI
{
    //presentation details
    //class COrderGUI created for the user interface
    //instantiates an object of the class COrder and instantiates a Windows Form OBJECT to represent the grahical user interface
    //using the .NET predefined Control classes - (Label, ComboBox, ListBox, RadioButton, ChekBox, and Menu) - 
    //using the .NET predefined Control classes - OBJECTS are added to the Form OBJECT
     
    //class COrderGUI allows the user to (1) select an entrée (2) and a drink  (3) enter special requests (4) and request water
    //CONSTANT = drinkSelections = "milk" "juice" "soda" "lemonade" "tea" "coffee"

    //menu options may change occasionally and should not be STATICALLY placed on the graphical user interface
    //current options "chickenSalad" "hamAndCheese" "turkey" "vegetableWrap" "tunaSalad" "avocadoAndCheese" "club" "peanAndJell" "grilledCheese" "reuben"

    class COrderGUI
    {
        //MenuStrip OBJECT selected rather than a number of buttons

        //ListBox OBJECT = entrées
        //The text selections for the ListBox OBJECT are loaded at run time to enable the diner manager to 
        //change the menu options in the class that deals with the business logic
        //and keep that separate from the actual display
        
        //special requests are stored in a ComboBox OBJECT bc it enables users to eith choose from a list of options or to type a new entry

        //CheckBox OBJECT= water selection yes/no bool format

        //RadioButton OBJECTS = drink selection GroupBox

    }
}
