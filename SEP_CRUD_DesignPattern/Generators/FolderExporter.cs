using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class FolderExporter<T> : IExport where T: IExport
    {
        protected string folderName;
        protected List<T> children = new List<T>();

        public FolderExporter(string folderName)
        {
            this.folderName = folderName;
        }
        public void ExportAt(string rootPath)
        {
            string path = rootPath + "/" + folderName;
            children.ForEach(
                (item) =>
                {
                    item.ExportAt(path);
                });
        }
        public void Add(T item)
        {
            children.Add(item);
        }
        public void Remove(T item)
        {
            children.Remove(item);
        }
    }
}