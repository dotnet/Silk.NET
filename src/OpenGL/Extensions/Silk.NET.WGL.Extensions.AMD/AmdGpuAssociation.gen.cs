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

namespace Silk.NET.WGL.Extensions.AMD
{
    [Extension("AMD_gpu_association")]
    public unsafe partial class AmdGpuAssociation : NativeExtension<WGL>
    {
        public const string ExtensionName = "AMD_gpu_association";
        [NativeApi(EntryPoint = "wglBlitContextFramebufferAMD", Convention = CallingConvention.Winapi)]
        public partial void BlitContextFramebuffer([Flow(FlowDirection.In)] nint dstCtx, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] AMD filter);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial nint CreateAssociatedContext([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAttribsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAssociatedContextAttrib([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] nint hShareContext, [Flow(FlowDirection.In)] int* attribList);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAttribsAMD", Convention = CallingConvention.Winapi)]
        public partial nint CreateAssociatedContextAttrib([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] nint hShareContext, [Flow(FlowDirection.In)] in int attribList);

        [NativeApi(EntryPoint = "wglDeleteAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DeleteAssociatedContext([Flow(FlowDirection.In)] nint hglrc);

        [NativeApi(EntryPoint = "wglGetContextGPUIDAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetContextGpuid([Flow(FlowDirection.In)] nint hglrc);

        [NativeApi(EntryPoint = "wglGetCurrentAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentAssociatedContext();

        [NativeApi(EntryPoint = "wglGetGPUIDsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetGpuids([Flow(FlowDirection.In)] uint maxCount, [Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "wglGetGPUIDsAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetGpuids([Flow(FlowDirection.In)] uint maxCount, [Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "wglGetGPUInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGpuinfo([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] int property, [Flow(FlowDirection.In)] AMD dataType, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "wglMakeAssociatedContextCurrentAMD", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeAssociatedContextCurrent([Flow(FlowDirection.In)] nint hglrc);

        public AmdGpuAssociation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

