using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmScreen.AccountManagement
{
    interface IFileInfo
    {
        string Name { get; set; }
        string Description { get; set; }
        string MimeType { get; set; }
        Stream Content { get; }
    }
}
