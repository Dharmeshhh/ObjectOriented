public class Salesman : Employees
{
    private string _salesmanRegion;
    public Salesman() { }

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