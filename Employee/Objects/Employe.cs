public class Employe
{
  int _Id;
  string _Firstname;
  string _Lastname;
  int _Salary;

  public Employe(int id, string firstname, string lastname, int salary)
  {
    _Id = id;
    _Firstname = firstname;
    _Lastname = lastname;
    _Salary = salary;
  } 
  public int GetId()
  {
    return _Id;
  }
  public string GetFirstname()
  {
    return _Firstname;
  }
  public string GetLastname()
  {
    return _Lastname;
  }
  public string GetName()
  {
    return _Firstname +"  " + _Lastname;
  }
  public int GetSalary()
  {
    return _Salary;
  }
  public void SetSalary(int salary)
  {
    _Salary = salary;
  }
  public int GetAnnualSalary()
  {
    return _Salary *12;
  }
  public int raiseSalary(int persent)
  {
    return ((_Salary * persent)/100)+_Salary;
  }
  public string ToStringes()
  {
    return ($"Id = {_Id},name = {_Firstname},Lastname = {_Lastname}, salary = {_Salary}");
  }
}