using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapGenerateUserPass
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Generation of Password using First name, last name and aga as Input parameters
        public string password(string firstName, string lastName, int age)
        {

            int newAge = age % 5;

            string output = lastName.Substring(0, 2) + firstName.Substring(firstName.Length - 2, 2) + newAge.ToString();
            return output;
        }

        //Generation of LoginId using age as Input parameter
        public int loginId(int age)
        {
            Random rndGenerate = new Random();
            int rand = rndGenerate.Next(100, 201);
            return age * rand;
        }
    }
}
