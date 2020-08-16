using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    public partial class SDL
    {
        public static SDL GetApi()
        {
            return new SDL(new DefaultNativeContext(new SDLLibraryNameContainer().GetLibraryName()));
        }

        public override bool IsExtensionPresent(string extension) => GLExtensionSupported(extension) == SdlBool.True;
    }
}

