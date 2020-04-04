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
    [Extension("EXT_base_instance")]
    public abstract unsafe partial class ExtBaseInstance : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstanceEXT")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstanceEXT")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        public ExtBaseInstance(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

