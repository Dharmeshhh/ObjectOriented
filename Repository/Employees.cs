public class Employees
{
    private int _empID;
    private string _empName;
    private string _empLocation;
    protected int salary;
    public Employees(int salary){
        this.salary = salary;
    }

    public int EmpID
    {
        set
        {
            this._empID = value;
        }
        get
        {
            return this._empID;
        }
    }
    public string EmpName
    {
        set
        {
            this._empName = value;
        }
        get
        {
            return this._empName;
        }
    }
    public string EmpLocation
    {
        set
        {
            this._empLocation = value;
        }
        get
        {
            return this._empLocation;
        }
    }

}