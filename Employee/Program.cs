
System.Console.WriteLine("You mast entered your -  Id/Firstname/Lastname/salary");
System.Console.Write("Write your id =  ");
var myid = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write youre Firstame = ");
var myfirstname = Console.ReadLine();
System.Console.Write("Write youre Lasttame = ");
var mylastname = Console.ReadLine();
System.Console.Write("Write your salary = ");
var mysalary = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write persent = ");
var newsalary = Convert.ToInt32(Console.ReadLine());
var Object1 = new Employe(myid, myfirstname, mylastname, mysalary);
System.Console.WriteLine($" Youre Id  : {Object1.GetId()}\n FullName : {Object1.GetName()}\n Youre Salary : {Object1.GetSalary()}");
System.Console.WriteLine($" Youre Annual Salary : {Object1.GetAnnualSalary()}\n Raise Salary : {Object1.raiseSalary(newsalary)}\n");




