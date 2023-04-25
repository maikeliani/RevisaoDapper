using RevisaoDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoDapper.Services
{
    public class AddressService
    {
        public AddressService() { }
        public List<Address> GetAll()
        {
            return new List<Address>();
        }

        public Address Insert (Address address)
        {
            return new Address();
        }
    }
}
