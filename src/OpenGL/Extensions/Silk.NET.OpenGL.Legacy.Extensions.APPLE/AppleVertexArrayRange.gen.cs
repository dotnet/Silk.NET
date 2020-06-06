// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_range")]
    public unsafe partial class AppleVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_array_range";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushVertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer)
            => ImplFlushVertexArrayRange(length, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushVertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
            => ImplFlushVertexArrayRange<T0>(length, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayParameter([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param)
            => ImplVertexArrayParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer)
            => ImplVertexArrayRange(length, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
            => ImplVertexArrayRange<T0>(length, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayParameter([Flow(FlowDirection.In)] VertexArrayPNameAPPLE pname, [Flow(FlowDirection.In)] int param)
            => ImplVertexArrayParameter(pname, param);

        public AppleVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

