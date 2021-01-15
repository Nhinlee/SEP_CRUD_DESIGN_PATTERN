using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Helpers
{
    class NamespaceHelper
    {
        private static NamespaceHelper _instance = new NamespaceHelper();
        public static NamespaceHelper Instance { get => _instance; }
        private NamespaceHelper()
        {

        }
        //----------------------------------------------------------------
        public string ProjectNamespace { get; set; }

        public const string daos = "Daos";
        public const string forms = "Forms";
        public const string models = "Models";
        public const string hibernate = "Hibernates";

        public string ModelsNamespace { get => ProjectNamespace + "." + models; }
        public string FormsNamespace { get => ProjectNamespace + "." + forms; }
        public string DaosNamespace { get => ProjectNamespace + "." + daos; }
        public string HibernateNamespace { get => ProjectNamespace + "." + hibernate; }
        

    }
}
