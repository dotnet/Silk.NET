using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using ExtensionAttribute = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL
{
    public partial class EGL
    {
        private string[] _extensions;
        
        public static EGL GetApi()
        {
            return new EGL(CreateDefaultContext(new EGLLibraryNameContainer().GetLibraryName()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<EGL>
        {
             ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }

        public override unsafe bool IsExtensionPresent(string extension)
        {
            if (_extensions is null)
            {
                var pExtensions = this.QueryString((nint) EGLEnum.NoDisplay, (int) EGLEnum.Extensions);
                _extensions = SilkMarshal.PtrToString((nint) pExtensions).Split(' ');
            }

            return _extensions.Contains(extension);
        }
    }
}

