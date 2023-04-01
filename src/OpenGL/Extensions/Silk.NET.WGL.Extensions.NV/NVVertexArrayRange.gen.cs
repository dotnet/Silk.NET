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
    [Extension("NV_vertex_array_range")]
    public unsafe partial class NVVertexArrayRange : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_vertex_array_range";
        [NativeApi(EntryPoint = "wglAllocateMemoryNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void* AllocateMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float readfreq, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float writefreq, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float priority);

        [NativeApi(EntryPoint = "wglFreeMemoryNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void FreeMemory([Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "wglFreeMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void FreeMemory<T0>([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        public unsafe T0 FreeMemory<T0>() where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            FreeMemory(out T0 silkRet);
            return silkRet;
        }

        public NVVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

