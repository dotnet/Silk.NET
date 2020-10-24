// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_range")]
    public unsafe partial class AppleVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_array_range";
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        public unsafe partial void FlushVertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE")]
        public partial void FlushVertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        public partial void VertexArrayParameter([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE")]
        public partial void VertexArrayParameter([Flow(FlowDirection.In)] VertexArrayPNameAPPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        public unsafe partial void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE")]
        public partial void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        public AppleVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

