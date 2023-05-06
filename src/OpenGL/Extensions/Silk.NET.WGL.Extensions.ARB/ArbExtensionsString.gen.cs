// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.ARB
{
    [Extension("ARB_extensions_string")]
    public unsafe partial class ArbExtensionsString : NativeExtension<WGL>
    {
        public const string ExtensionName = "ARB_extensions_string";
        [NativeApi(EntryPoint = "wglGetExtensionsStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* GetExtensionsString([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "wglGetExtensionsStringARB", Convention = CallingConvention.Winapi)]
        public partial string GetExtensionsStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc);

        public ArbExtensionsString(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

