namespace EmployePayroll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeModel model = new EmployeeModel();
         
            model.EmployeeName = "Bruce";
            model.PhoneNumber = 1234567890;
            model.Address = "Banglore";
            model.Department = "HR";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.TaxablePay = 200;
            model.Tax = 300;
            model.NetPay = 2500;
            model.City = "Benglore";
            model.Country = "India";


            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployee();
            //repo.AddEmployee(model);
        }
    }
}