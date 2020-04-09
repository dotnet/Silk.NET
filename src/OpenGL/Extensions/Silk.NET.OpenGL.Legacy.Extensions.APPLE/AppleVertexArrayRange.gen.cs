// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_range")]
    public abstract unsafe partial class AppleVertexArrayRange : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        public abstract unsafe void FlushVertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        public abstract void FlushVertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        public abstract void VertexArrayParameter([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        public abstract unsafe void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        public abstract void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        public abstract void VertexArrayParameter([Flow(FlowDirection.In)] VertexArrayPNameAPPLE pname, [Flow(FlowDirection.In)] int param);

        public AppleVertexArrayRange(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

