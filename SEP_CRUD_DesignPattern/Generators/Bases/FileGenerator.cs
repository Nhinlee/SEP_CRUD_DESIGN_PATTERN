using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Bases
{
    public abstract class FileGenerator : Generator
    {
        public override string GetFullRelativePath()
        {
            if (this.RelativePath != "" && this.RelativePath != null)
                return this.RelativePath + "/" + GetFileName();
            else return GetFileName();
        }
        public override void ExportToFile(string rootPath)
        {
            string path = rootPath;
            if (RelativePath != "")
            {
                path += "/" + RelativePath;
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (path.EndsWith("/"))
            {
                path += GetFileName();
            }
            else
            {
                path += '/' + GetFileName();
            }

            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.Write(GetSourceCode());
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
