using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class FileExporter : IExport
    {   
        protected string fileName;
        protected string sourceCode;

        public FileExporter(Generator generator)
        {
            this.fileName = generator.GetFileName();
            this.sourceCode = generator.GetSourceCode();
        }

        public void ExportAt(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }

            string path = rootPath;
            if (path.EndsWith("/")) path += fileName;
            else path += '/' + fileName;

            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.Write(sourceCode);
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