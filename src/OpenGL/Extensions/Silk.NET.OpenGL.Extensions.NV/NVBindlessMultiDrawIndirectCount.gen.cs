// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_bindless_multi_draw_indirect_count")]
    public unsafe partial class NVBindlessMultiDrawIndirectCount : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_bindless_multi_draw_indirect_count";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        public partial void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawArraysIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
        public partial void MultiDrawArraysIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public unsafe partial void MultiDrawElementsIndirectBindlessCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
        public partial void MultiDrawElementsIndirectBindlessCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        public NVBindlessMultiDrawIndirectCount(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

