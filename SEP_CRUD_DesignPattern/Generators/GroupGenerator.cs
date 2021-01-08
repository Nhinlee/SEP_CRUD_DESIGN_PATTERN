using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public abstract class GroupGenerator<T> : FileGenerator where T: FileGenerator
    {
        protected List<T> files = new List<T>();
        public override void ExportToFile(string rootPath)
        {
            // Write this file
            base.ExportToFile(rootPath + "/" + this.Name);
            // Write all the relative file of this file
            for (int i = 0; i < files.Count; i++) 
            {
                files[i].ExportToFile(rootPath + "/" + this.Name);
            }
        }
        public void Add(T f)
        {
            this.files.Add(f);
        }
        public void Remove(T f)
        {
            this.files.Remove(f);
        }
        public List<T> GetFiles()
        {
            return files;
        }
    }
}
