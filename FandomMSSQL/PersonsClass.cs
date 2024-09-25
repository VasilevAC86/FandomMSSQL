using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace FandomMSSQL
{
    [Table(Name = "Persons")]
    public class PersonsClass
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { set; get; }
        [Column(Name = "name")]
        public string Name { set; get; }
        //public override string ToString()
        //{
        //    string result = Name;
        //    return result;
        //}
    }
}
