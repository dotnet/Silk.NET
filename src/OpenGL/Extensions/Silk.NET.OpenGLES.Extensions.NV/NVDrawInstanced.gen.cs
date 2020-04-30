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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_draw_instanced")]
    public abstract unsafe partial class NVDrawInstanced : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedNV")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedNV")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedNV")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public NVDrawInstanced(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

