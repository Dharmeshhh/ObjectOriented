public class Salesman : Employees
{
    private string _salesmanRegion;
    public Salesman(int salary): base(salary) { 
    }

    public string SalesmanRegion
    {
        set
        {
            this._salesmanRegion = value;
        }
        get
        {
            return this._salesmanRegion;
        }
    }
    public int TotalSalesOfTheMonth()
    {
        return 100000;
    }
}