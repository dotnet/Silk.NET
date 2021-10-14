// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using Android.Content.Res;

namespace AndroidInputDemo
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
