using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenCL
{
    public partial class CL
    {
        public static CL GetApi()
        {
             return LibraryLoader<CL>.Load(new OpenCLLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<CL>
        {
             ext = LibraryLoader<CL>.Load<T>(this);
             return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

