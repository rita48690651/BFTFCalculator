using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFTFCalculator.Models
{
    public class Calculator
    {
        public int money { get; set; }//(給使用者輸入的)借貸金額

        public  int rate { get; set; }//(給使用者輸入的)年利率

        public int period { get; set; }//I給使用者輸入的)貸款期數

        public int result { get; set; }

        public int due { get; set; }//當期應付款(當期應償還本金+當期應償還利息)

        public int PayPrinciple { get; set; }//當期應償還本金

        public int interest  { get; set; }//當期應償還利息

        public int remain { get; set; }//剩餘本金

        public int average { get; set; }//每月應付本息金額之平均攤還率
    }
}