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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_copy_image")]
    public unsafe partial class ArbCopyImage : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_copy_image";
        [NativeApi(EntryPoint = "glCopyImageSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] ARB srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] ARB dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] ARB srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] ARB dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        public ArbCopyImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

