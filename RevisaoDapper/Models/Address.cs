using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoDapper.Models
{
    public class Address
    {
        public readonly static string INSERT = "INSERT INTO Address (Street, IdCity) VALUES (@Street, @IdCity)";
        public readonly static string SELECT_ALL = "SELECT a.Id, a.Street, a.IdCity from Address a" +
                                                    "INNER JOIN City c on c.Id = a.IdCity";
        public int Id { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
    }
}
