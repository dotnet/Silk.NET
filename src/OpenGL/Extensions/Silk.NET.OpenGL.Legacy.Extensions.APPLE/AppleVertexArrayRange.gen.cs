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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_range")]
    public unsafe partial class AppleVertexArrayRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_array_range";
        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void FlushVertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FlushVertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayParameter([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayParameter([Flow(FlowDirection.In)] VertexArrayPNameAPPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayRange([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayRange<T0>([Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        public unsafe void FlushVertexArrayRange<T0>([Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            FlushVertexArrayRange((uint) (pointer.Length * Unsafe.SizeOf<T0>()), out pointer.GetPinnableReference());
        }

        public unsafe void VertexArrayRange<T0>([Count(Parameter = "length"), Flow(FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            VertexArrayRange((uint) (pointer.Length * Unsafe.SizeOf<T0>()), out pointer.GetPinnableReference());
        }

        public AppleVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

