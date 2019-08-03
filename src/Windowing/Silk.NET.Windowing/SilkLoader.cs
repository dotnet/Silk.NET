// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport.Loaders;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing
{
    public class SilkLoader : IPlatformLoader
    {
        ContextAPI _api;
        public SilkLoader(ContextAPI api)
        {
            _api = api;
        }
        
        public static SilkLoader OpenGL { get; } = new SilkLoader(ContextAPI.OpenGL);
        public static SilkLoader OpenGLES { get; } = new SilkLoader(ContextAPI.OpenGLES);
        
        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            return Silk.CurrentPlatform.GetProcAddress(_api, symbolName);
        }

        public IntPtr LoadLibrary(string path)
        {
            return IntPtr.Zero;
        }

        public bool CloseLibrary(IntPtr library)
        {
            return true;
        }
    }
}
