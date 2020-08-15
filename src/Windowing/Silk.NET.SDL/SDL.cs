using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    public partial class SDL
    {
        public static SDL GetApi()
        {
             return LibraryActivator.CreateInstance<SDL>(new SDLLibraryNameContainer().GetLibraryName());
        }

        public override bool IsExtensionPresent(string extension) => GLExtensionSupported(extension) == SdlBool.True;
    }
}

