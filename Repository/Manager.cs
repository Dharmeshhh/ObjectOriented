public class Manager : Employees
{
    private string _department;
    public Manager() { }

    public string Department
    {
        set
        {
            this._department = value;
        }
        get
        {
            return this._department;
        }
    }
    public long TotalSalesOfTheYear()
    {
        return 3000000000;
    }
}