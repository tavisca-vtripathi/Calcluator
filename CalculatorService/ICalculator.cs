using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double AddNumbers(double number1, double number2);
        [OperationContract]
        double SubstractNumbers(double number1, double number2);
        [OperationContract]
        double MultiplyNumbers(double number1, double number2);
        [OperationContract]
        double DivisionNumbers(double number1, double number2);
    }
}
