using Foundation;
using Northwinder.iOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalCache))]
namespace Northwinder.iOS
{
    class LocalCache : ILocalCache
    {
        private static string DocumentsPath
        {
            get
            {
                var documentsDirUrl = NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User).Last();
                return documentsDirUrl.Path;
            }
        }

        public async Task<string> LoadText(string filename)
        {
            string path = Path.Combine(DocumentsPath, filename);
            using (StreamReader sr = File.OpenText(path))
                return await sr.ReadToEndAsync();
        }

        public async void SaveText(string text, string filename)
        {
            string path = Path.Combine(DocumentsPath, filename);
            using (StreamWriter sw = File.CreateText(path)) {
                await sw.WriteAsync(text);
            }
        }
    }
}
