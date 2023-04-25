using RevisaoDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoDapper.Repositories
{
    public interface IAddressRepository
    {
        bool Insert(Address address);
        List<Address> GetAll();
    }
}
