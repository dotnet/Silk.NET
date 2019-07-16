using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenGL.Legacy
{
    partial class GL
    {
        public static GL GetApi()
        {
             return LibraryLoader<GL>.Load(new OpenGLLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<GL>
        {
             ext = LibraryLoader<GL>.Load<T>(this);
             return ext != null;
        }
        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

