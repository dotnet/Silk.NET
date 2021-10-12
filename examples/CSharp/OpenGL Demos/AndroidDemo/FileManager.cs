using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;

namespace AndroidDemo
{
    /// <summary>
    /// Helper to assist with file loading.
    /// </summary>
    public static class FileManager
    {
        internal static AssetManager AssetManager;

        public static string LoadString(string path)
        {
            using StreamReader s = new StreamReader(AssetManager.Open(path));
            return s.ReadToEnd();
        }

        public static Stream OpenStream(string path)
        {
            return AssetManager.Open(path);
        }
    }
}
