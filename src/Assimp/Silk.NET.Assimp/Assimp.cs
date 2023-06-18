using System;
using System.Runtime.InteropServices;
using System.Text;
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

        public override unsafe bool IsExtensionPresent(string extension)
        {
            fixed (byte* extPtr = Encoding.UTF8.GetBytes(extension))
            {
                return IsExtensionSupported(extPtr) == 1;
            }
        }
    }
}

