using System;
using cSharpRussianRoulette;
using cSharpRussianRoulette.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]

        public void RndNumberTest()
           

        {    
            gamePlay myGamePlay = new gamePlay();

            //create a random number

            int myRandNum = myGamePlay.RndNumber();
            //checkif the numbger is >0 and < 7
            Assert.IsTrue(myRandNum > 0 && myRandNum < 7);

        }
    }
}
