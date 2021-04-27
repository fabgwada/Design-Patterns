using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public abstract class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }


    public class Lead : Customer
    {

    }

    public class Buyer : Customer
    {
        public Invoice Invoice { get; set; }
    }
}
