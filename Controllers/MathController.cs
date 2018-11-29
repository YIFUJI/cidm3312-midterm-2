using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using cidm3312midterm2.Models;
using MathLibrary;

namespace MidtermExam2.Controllers
{
    public class MathOperation: Controller
    {
        [HttpGet]
        public IActionResult DoCaclucation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowCalculationResultsx(MathOperation data)
        {
            switch (operation.Operator)
            {
                case "+":
                    data.Result = MathLibrary.Add(data.LeftOperand, data.RightOperand)
                    break;
                case "-":
                    data.Result = MathLibrary.Subtract(data.LeftOperand, data.RightOperand)
                    break;
                case "*":
                    data.Result = MathLibrary.Multiply(data.LeftOperand, data.RightOperand)
                    break;
                case "/":
                    data.Result = MathLibrary.Divide(data.LeftOperand, data.RightOperand)
                    break;
                default;
                break;

            }
            return View(data);
        }
    }
}