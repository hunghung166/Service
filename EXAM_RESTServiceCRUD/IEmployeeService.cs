using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EXAM_RESTServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,

            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Employees/")]
        List<Employee> GetEmployeeList();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,

            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Employees/{department}")]
        Employee GetEmployeeByDepartment(string department);

        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,

           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AddEmployee/{id}")]
        string AddEmployee(Employee employee, string id);
    }
}
