using System.Collections.Generic;

namespace SEP_CRUD_DesignPattern.DB
{
    public class Table : DatabaseProperty
    {
        public List<Column> Columns { get; set; } = new List<Column>();

        public void Clear()
        {
            Columns.Clear();
        }
    }
}