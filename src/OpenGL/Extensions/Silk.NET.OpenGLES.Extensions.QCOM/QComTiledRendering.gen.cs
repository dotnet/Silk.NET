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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_tiled_rendering")]
    public unsafe partial class QComTiledRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_tiled_rendering";
        [NativeApi(EntryPoint = "glEndTilingQCOM", Convention = CallingConvention.Winapi)]
        public partial void EndTiling([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint preserveMask);

        [NativeApi(EntryPoint = "glEndTilingQCOM", Convention = CallingConvention.Winapi)]
        public partial void EndTiling([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferBitQCOM preserveMask);

        [NativeApi(EntryPoint = "glStartTilingQCOM", Convention = CallingConvention.Winapi)]
        public partial void StartTiling([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint preserveMask);

        [NativeApi(EntryPoint = "glStartTilingQCOM", Convention = CallingConvention.Winapi)]
        public partial void StartTiling([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferBitQCOM preserveMask);

        public QComTiledRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

