using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.EGL
{
    public partial class EGL
    {
        public static EGL GetApi()
        {
             return LibraryLoader<EGL>.Load(new EGLLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<EGL>
        {
             ext = LibraryLoader<EGL>.Load<T>(this);
             return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
        }
    }
}

