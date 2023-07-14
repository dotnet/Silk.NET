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

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_copy_image")]
    public unsafe partial class NVCopyImage : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_copy_image";
        [NativeApi(EntryPoint = "wglCopyImageSubDataNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 CopyImageSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hSrcRC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV srcTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDstRC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV dstTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        public NVCopyImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

