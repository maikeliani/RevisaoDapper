using RevisaoDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Data.SqlClient;

namespace RevisaoDapper.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private string Conn { get; set;}

        public AddressRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConntection"].ConnectionString;
        }
        public List<Address> GetAll()
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                var addresses = db.Query<Address, City, Address>(Address.SELECT_ALL, (address, city) =>
                {
                    address.City = city;
                    return address;
                }, splitOn: "IdCity");

                return (List<Address>) addresses;
            }
        }

        public bool Insert(Address address)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Address.INSERT, address);
                status = true;
            }

            return status;
        }
    }
}
