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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_array_range")]
    public unsafe partial class NVVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_array_range";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushVertexArrayRange()
            => ImplFlushVertexArrayRange();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from length.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexArrayRange(length, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from length.
        /// </param>
        [NativeApi(EntryPoint = "glVertexArrayRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexArrayRange<T0>(length, pointer);

        public NVVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

