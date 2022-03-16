using System.Text.Json;

namespace ficha10
{

    public class Employees:IEmployees
    {   
       private List<Employee> employeesList;

      
       /* public Employees()
        {

            List<Employee> EmployeesList=new List<Employee>();
        }*/
        
        /*public Employees(List<Employee> achar)
        {
            EmployeesList = achar;
        }*/

        public List<Employee> EmployeesList { get; set; }

        public Employees()
        {
            employeesList=JsonLoader.LoadEmployees();
        }
    }
}
