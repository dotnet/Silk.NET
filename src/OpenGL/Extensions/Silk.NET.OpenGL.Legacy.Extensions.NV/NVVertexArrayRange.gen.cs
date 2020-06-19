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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_array_range")]
    public abstract unsafe partial class NVVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_array_range";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeNV")]
        public abstract void FlushVertexArrayRange();

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
        public abstract unsafe void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] void* pointer);

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
        public abstract void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public NVVertexArrayRange(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

