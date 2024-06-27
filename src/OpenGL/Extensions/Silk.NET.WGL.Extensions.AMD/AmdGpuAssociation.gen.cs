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
        public partial void BlitContextFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dstCtx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD filter);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial nint CreateAssociatedContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAttribsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAssociatedContextAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribList);

        [NativeApi(EntryPoint = "wglCreateAssociatedContextAttribsAMD", Convention = CallingConvention.Winapi)]
        public partial nint CreateAssociatedContextAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attribList);

        [NativeApi(EntryPoint = "wglDeleteAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DeleteAssociatedContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrc);

        [NativeApi(EntryPoint = "wglGetContextGPUIDAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetContextGpuid([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrc);

        [NativeApi(EntryPoint = "wglGetCurrentAssociatedContextAMD", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentAssociatedContext();

        [NativeApi(EntryPoint = "wglGetGPUIDsAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetGpuids([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "wglGetGPUIDsAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetGpuids([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "wglGetGPUInfoAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetGpuinfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int property, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "wglGetGPUInfoAMD", Convention = CallingConvention.Winapi)]
        public partial int GetGpuinfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int property, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "wglMakeAssociatedContextCurrentAMD", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeAssociatedContextCurrent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrc);

        public AmdGpuAssociation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

