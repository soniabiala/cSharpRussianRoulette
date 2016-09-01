using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;

namespace cSharpRussianRoulette.classes
{
    public class gamePlay
    {

        //Field

        //public TextBox NameLabel = new TextBox();

        //constructor - holds the default values for your properties, fields 
        //public gamePlay()
        //{
        //   // FirstName = "no one";
        //    lLstname = "Here yet";

        //}
         //Property

        //public string FirstName { get; set; } = "no one";
        //public String lLstname { get; set; }


        //private int __counter;

        //public int Counter //propfull
        //{
        //    get //when the data GETS called by the program
        //    {
        //        if (__counter > 5)
        //        {

        //            __counter = 0;
        //        }
        //        return __counter;
        //    }

        //    set //when the data is SET into the property program
        //    { __counter = value; }
        //}

        //public int AnoutherCounter { get; set; } //prop


        //methods

        //public void FullName()
        //{
        //    NameLabel.Text = FirstName + " " + lLstname;


        //}


        public int RndNumber()
        {
            //create a random number
            Random num = new Random();
            int rndNum = num.Next(1, 7);
            //send the number back to the program
            return rndNum;

        }

    }
}
