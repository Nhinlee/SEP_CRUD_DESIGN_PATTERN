namespace SEP_CRUD_DesignPattern.DB
{
    public class Column : DatabaseProperty
    {
        // TODO: is primary key should set at constructor
        public bool IsPrimaryKey { get; set; }
        public string DatabaseType { get; set; }
        public string Type { get; set; }
    }
}