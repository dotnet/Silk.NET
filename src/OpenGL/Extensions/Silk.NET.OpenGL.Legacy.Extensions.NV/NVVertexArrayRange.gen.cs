// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_array_range")]
    public unsafe partial class NVVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_array_range";
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeNV")]
        public partial void FlushVertexArrayRange();

        [NativeApi(EntryPoint = "glVertexArrayRangeNV")]
        public unsafe partial void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexArrayRangeNV")]
        public partial void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public NVVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

