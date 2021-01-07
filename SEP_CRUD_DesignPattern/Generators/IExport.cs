using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD_DesignPattern.Generators
{
    public interface IExport
    {
        void ExportAt(string rootPath);
    }
}