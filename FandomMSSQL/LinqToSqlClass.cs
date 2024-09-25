using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace FandomMSSQL
{
    internal class LinqToSqlClass
    {
        static string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=Fandom;" +
            "Integrated Security=True;";
        static public List<string> GetNames(string _pattern = "<empty>") // При нажатии на имена выводит их все
        {
            List<string> result = new List<string>();
            DataContext dc = new DataContext(connectionString); // Для сохранения область видимости локального сервера
            Table<PersonsClass> _persons = dc.GetTable<PersonsClass>();
            if (_pattern.Equals("<empty>"))
            { // Складываем внутрь result все имена
                foreach (var item in _persons)
                {
                    result.Add(item.Name);
                }
            }
            else
            {
                var tmpSequence = from _person in _persons // _persons - это табл, которую мы забрали из DataContext
                                  where _person.Name.Contains(_pattern) // поиск имени по строке _pattern
                                  select _person;
                foreach (var item in tmpSequence)
                {
                    result.Add(item.Name);
                }
            }
            return result;
        }
        // Логический тип, чтобы знать, надо ли перерисовывать dgv
        static public bool ReplaceName(string _oldName, string _newName)
        {
            bool IsFound = false;
            DataContext dc = new DataContext(connectionString); // Для сохранения область видимости локального сервера
            Table<PersonsClass> _persons = dc.GetTable<PersonsClass>();
            foreach (var item in _persons)
            {
                if (item.Name == _oldName)
                {
                    IsFound = true;
                    item.Name = _newName;
                }
            }
            dc.SubmitChanges(); // Подтверждаем изменения
            return IsFound;
        }
    }
}
