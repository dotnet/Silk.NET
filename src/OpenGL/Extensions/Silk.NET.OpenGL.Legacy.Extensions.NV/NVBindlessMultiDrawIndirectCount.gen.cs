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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_bindless_multi_draw_indirect_count")]
    public unsafe partial class NVBindlessMultiDrawIndirectCount : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_bindless_multi_draw_indirect_count";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        public NVBindlessMultiDrawIndirectCount(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

