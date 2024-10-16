namespace cvApp.Models;
public class TaxCalculator
{
    public decimal AnnualIncome { get; set; }
    public decimal TaxAmount { get; set; }
    
    public decimal CalculateTax()
    {
        // Nigerian PAYE tax brackets
        if (AnnualIncome <= 300000)
            return AnnualIncome * 0.07m; // 7% for low income
        else if (AnnualIncome <= 600000)
            return AnnualIncome * 0.11m; // 11% for moderate income
        // Add more brackets as needed
        
        return AnnualIncome * 0.24m; // Top tax bracket
    }
}
