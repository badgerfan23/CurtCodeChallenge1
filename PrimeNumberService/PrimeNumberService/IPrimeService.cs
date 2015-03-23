using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrimeNumberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPrimeService
    {
        [OperationContract]
        [
             WebInvoke(Method = "*",
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Wrapped,
             UriTemplate = "ShowThousandPrime/")
         ]

        string ShowThousandPrime();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ListThousandPrimes
    {
        [DataMember]
        private StringBuilder PrimeNumber = new StringBuilder();        

        public void setPrimeNumber(string num){
            PrimeNumber.Append(num);
        }

        public string getPrimeNumber() {
            return PrimeNumber.ToString();
        }

        public void removeLast() {
            PrimeNumber.Length --;
            PrimeNumber.Length--;
        }
    }
}
