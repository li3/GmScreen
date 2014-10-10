using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmScreen.AccountManagement
{
    interface ICloudService
    {
        string ServiceName { get; }
        Task<bool> Login();
        Task Logout();
        Task SaveFile(string path, IFileInfo fileInfo);
        Task<IFileInfo> LoadFile(string path, string filename);
    }
}
