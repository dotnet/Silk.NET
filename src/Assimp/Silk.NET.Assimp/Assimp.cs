using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeApi(Convention = CallingConvention.Winapi)]
    public partial class Assimp
    {
        public static Assimp GetApi()
        {
             return new Assimp(CreateDefaultContext(new AssimpLibraryNameContainer().GetLibraryNames()));
        }

        public override bool IsExtensionPresent(string extension) => IsExtensionSupported(extension) == 1;
    }
}

