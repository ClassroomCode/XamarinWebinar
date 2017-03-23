using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwinder
{
    public interface ILocalCache
    {
        Task<string> LoadText(string filename);
        void SaveText(string text, string filename);
    }
}
