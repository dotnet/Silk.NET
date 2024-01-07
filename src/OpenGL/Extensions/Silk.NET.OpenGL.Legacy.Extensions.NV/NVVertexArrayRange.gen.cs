// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_array_range")]
    public unsafe partial class NVVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_array_range";
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeNV", Convention = CallingConvention.Winapi)]
        public partial void FlushVertexArrayRange();

        [NativeApi(EntryPoint = "glVertexArrayRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexArrayRangeNV", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pointer) where T0 : unmanaged;

        public NVVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

