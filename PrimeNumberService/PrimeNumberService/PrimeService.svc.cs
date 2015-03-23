using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrimeNumberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PrimeService : IPrimeService
    {
        private const int LimitPrimeNumber = 1000;

        public Boolean IsPrime(int num)
        {
            int factor = num / 2;

            for (int j = 2; j <= factor; j++)
            {
                if ((num % j) == 0) return false;
            }

            return true;
        }

        public string ShowThousandPrime()
        {
            ListThousandPrimes answer = new ListThousandPrimes();

            int number = 0;

            int indexPrime = 0;

            while (indexPrime <= LimitPrimeNumber + 1)
            {

                if (IsPrime(number))
                {
                    if (number >= 2) answer.setPrimeNumber(number.ToString() + ", ");

                    indexPrime++;
                }

                number++;
            }

            answer.removeLast();

            return answer.getPrimeNumber();
        }
    }
}
