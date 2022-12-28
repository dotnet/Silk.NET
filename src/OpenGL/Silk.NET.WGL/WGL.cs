using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL
{
    public unsafe partial class WGL
    {
        private readonly Dictionary<nint, HashSet<string>> _extensions = new();
        public static WGL GetApi() => new(CreateDefaultContext("opengl32.dll"));

        public bool TryGetDcExtension<T>(nint hDc, out T ext)
            where T:NativeExtension<WGL>
        {
             ext = IsDcExtensionPresent(hDc, $"WGL_{GetExtensionAttribute(typeof(T)).Name}")
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }

        [Obsolete("Use IsDcExtensionPresent instead", true)]
        public override bool IsExtensionPresent(string extension) => IsDcExtensionPresent(0, extension);

        public bool IsDcExtensionPresent(nint hDc, string extension)
        {
            if (_extensions.TryGetValue(hDc, out var extensions))
            {
                return extensions.Contains(extension);
            }

            var getExtStrPtr = GetProcAddress("wglGetExtensionsStringARB");
            if (getExtStrPtr == 0)
            {
                throw new NotSupportedException("Can't retrieve extensions string (wglGetExtensionsStringARB is missing)");
            }

#if NET6_0_OR_GREATER
            var exts = ((delegate* unmanaged<nint, byte*>) getExtStrPtr)(hDc);
#else
            var exts = SilkMarshal.IsWinapiStdcall
                ? ((delegate* unmanaged[Stdcall]<nint, byte*>) getExtStrPtr)(hDc)
                : ((delegate* unmanaged[Cdecl]<nint, byte*>) getExtStrPtr)(hDc);
#endif

            var hs = SilkMarshal.PtrToString((nint) exts)?
                .Split(' ')
                .ToHashSet() ?? new HashSet<string>();
            _extensions.Add(hDc, hs);
            return hs.Contains(extension);
        }
    }
}

