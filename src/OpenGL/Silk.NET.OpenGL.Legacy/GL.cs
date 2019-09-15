using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenGL.Legacy
{
    public partial class GL
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

        private List<string> _extensions;
        public override bool IsExtensionPresent(string extension)
        {
            _extensions ??= Enumerable.Range(0, GetInteger(GLEnum.NumExtensions))
                .Select(x => GetString(GLEnum.Extensions, (uint) x)).ToList();

            return _extensions.Contains(extension);
        }
    }
}

