// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_instanced_arrays")]
    public abstract unsafe partial class ExtInstancedArrays : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribDivisorEXT")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public ExtInstancedArrays(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

