using System;
public class Employee
{
    //instance fields
    private int _empID;
    private string _empName;
    private string _job;
    private long _salary;
   

    public long Salary { get; set; } = 30000;
    //public long Salary { get; set; } = 30000;

    //instance property
    public int EmpID
    {
        set
        {
            if (value >= 100)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }

    //instance property
    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    //instance property
    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }

    //static field
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }


    //instance constructor //constructor 1
    public Employee(int empID, string empName, string job)
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
    }

    //constructor 2
    public Employee(int empID, string empName)
    {
        this._empID = empID;
        this._empName = empName;
    }

    //constructor 3
    public Employee()
    {
        _empID = 1;
    }

    //static constructor
    static Employee()
    {
        _companyName = "ABC Industries";
    }
}

public class Indexer
{
    private string[] _roles = new string[] { "CEO", "Manager", "Associate" };
    private string[] _indexRoles = new string[] { "first", "second", "third" };

    // public indexer standard
    public string this[int index]
    {
        set
        {
            this._roles[index] = value;
        }
        get
        {
            return this._roles[index];
        }

    }

    //indexer overloading 
    public string this[string name]
    {
        set
        {
            this._roles[Array.IndexOf(_indexRoles,name)] = value;
            //this._indexRoles[index] = value;
        }
        get
        {
            return this._roles[Array.IndexOf(_indexRoles, name)];
            //return this._indexRoles[index];
        }

    }
}