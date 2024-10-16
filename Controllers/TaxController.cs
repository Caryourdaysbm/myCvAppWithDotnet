using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cvApp.Models;

namespace cvApp.Controllers;
public class TaxController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(decimal annualIncome)
    {
        var taxCalculator = new TaxCalculator { AnnualIncome = annualIncome };
        var taxAmount = taxCalculator.CalculateTax();
        
        ViewBag.TaxAmount = taxAmount;
        return View("Result");
    }
}
