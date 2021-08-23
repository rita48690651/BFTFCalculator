using BFTFCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFTFCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator c)
        {
            if (int i = 1;i< c.period;i++)
            {
                c.average = (((1 + c.rate) * c.period) * c.rate) / (((1 + c.rate) * c.period) - 1);//計算每月應付本息金額之平均攤還率
                c.due = c.money * c.average;//計算每月應付款(每月應還本金金額+每月應付利息金額)
                c.interest = c.remain * c.rate;//計算每月應付利息
                c.PayPrinciple = c.due - c.interest;//計算每月應還本金
            }
            return View(c);
        }
    }
}