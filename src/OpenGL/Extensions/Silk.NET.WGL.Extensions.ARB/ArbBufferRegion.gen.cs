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
    [Extension("ARB_buffer_region")]
    public unsafe partial class ArbBufferRegion : NativeExtension<WGL>
    {
        public const string ExtensionName = "ARB_buffer_region";
        [NativeApi(EntryPoint = "wglCreateBufferRegionARB", Convention = CallingConvention.Winapi)]
        public partial nint CreateBufferRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uType);

        [NativeApi(EntryPoint = "wglDeleteBufferRegionARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteBufferRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hRegion);

        [NativeApi(EntryPoint = "wglRestoreBufferRegionARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 RestoreBufferRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hRegion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ySrc);

        [NativeApi(EntryPoint = "wglSaveBufferRegionARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SaveBufferRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hRegion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int height);

        public ArbBufferRegion(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

