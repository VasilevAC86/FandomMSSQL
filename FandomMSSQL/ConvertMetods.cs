using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FandomMSSQL
{
    internal class ConvertMetods
    {
        // Метод для конвертации
        public static DataTable ListOfStrings2DataSet(List<string> _lst)
        {
            DataTable result = new DataTable();
            result.Columns.Add("Имя");
            foreach (string str in _lst)
            { 
                result.Rows.Add(str);
            }
            return result;
        }
    }
}
