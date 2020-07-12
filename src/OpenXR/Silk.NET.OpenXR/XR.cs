using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public partial class XR
    {
        public static XR GetApi()
        {
             return LibraryLoader<XR>.Load(new OpenXRLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<XR>
        {
             ext = LibraryLoader<XR>.Load<T>(this);
             return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

