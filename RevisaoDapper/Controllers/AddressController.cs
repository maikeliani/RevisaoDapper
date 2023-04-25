using RevisaoDapper.Models;
using RevisaoDapper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoDapper.Controllers
{
    public class AddressController
    {
        private AddressService _addressService;
        public AddressController() 
        {
            _addressService = new AddressService();
        }
        public List<Address> GetAddresses()
        {
            return _addressService.GetAll();
        }

        public Address InsertAddress(Address address)
        {
            return _addressService.Insert(address);
        }
    }
}
