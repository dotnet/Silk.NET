using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL
{
    public partial class WGL
    {
        public static WGL GetApi()
        {
            var ctx = new MultiNativeContext(null, CreateDefaultContext(new string[] { "Opengl32.dll" }));
            var ret = new WGL(ctx);
            ctx.Contexts[0] = new LamdaNativeContext
            (
                (string proc, out nint pfn) => (pfn = proc != "wglGetProcAddress" ? ret.GetProcAddress(proc) : 0) != 0
            );
            return ret;
        }

        public bool TryGetExtension<T>(out T ext) where T:NativeExtension<WGL>
            => TryGetExtension(out ext, GetCurrentDC());

#if NET5_0_OR_GREATER
        public bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(out T ext, nint hdc)
#else
        public bool TryGetExtension<T>(out T ext, nint hdc)
#endif
            where T:NativeExtension<WGL>
        {
             ext = IsExtensionPresent(GetExtensionAttribute(typeof(T)).Name, hdc)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }
        
        public override bool IsExtensionPresent(string extension) => IsExtensionPresent(extension, GetCurrentDC());
        
        private ConcurrentDictionary<nint, HashSet<string>> _extensions;
        
        [NativeApi(EntryPoint = "wglGetExtensionsStringARB")]
        private partial string GetExtensionsString(nint hdc);

        private static HashSet<string>? _empty;
        private bool _hasGetExtensionsString;
        
        public bool IsExtensionPresent(string extension, nint hdc) => _extensions.GetOrAdd
            (
                hdc, hdc => !(_hasGetExtensionsString =
                    _hasGetExtensionsString || GetProcAddress("wglGetExtensionsStringARB") != 0)
                    ? _empty ??= new HashSet<string>()
                    : new HashSet<string>(GetExtensionsString(hdc).Split(' ')) 
            )
            .Contains(extension.StartsWith("WGL_") ? extension : $"WGL_{extension}");
    }
}

