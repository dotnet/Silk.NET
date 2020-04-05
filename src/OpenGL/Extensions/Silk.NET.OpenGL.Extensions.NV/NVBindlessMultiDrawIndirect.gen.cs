// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_bindless_multi_draw_indirect")]
    public abstract unsafe partial class NVBindlessMultiDrawIndirect : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessNV")]
        public abstract unsafe void MultiDrawArraysIndirectBindles([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessNV")]
        public abstract void MultiDrawArraysIndirectBindles<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessNV")]
        public abstract unsafe void MultiDrawElementsIndirectBindles([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessNV")]
        public abstract void MultiDrawElementsIndirectBindles<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessNV")]
        public abstract unsafe void MultiDrawArraysIndirectBindles([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectBindlessNV")]
        public abstract void MultiDrawArraysIndirectBindles<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessNV")]
        public abstract unsafe void MultiDrawElementsIndirectBindles([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectBindlessNV")]
        public abstract void MultiDrawElementsIndirectBindles<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged;

        public NVBindlessMultiDrawIndirect(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

