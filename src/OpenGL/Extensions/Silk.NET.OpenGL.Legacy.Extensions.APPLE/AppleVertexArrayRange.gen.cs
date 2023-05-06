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
        public unsafe partial void FlushVertexArrayRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glFlushVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FlushVertexArrayRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayParameteriAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPNameAPPLE pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pointer);

        [NativeApi(EntryPoint = "glVertexArrayRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pointer) where T0 : unmanaged;

        public unsafe void FlushVertexArrayRange<T0>([Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            FlushVertexArrayRange((uint) ((pointer.Length) * Unsafe.SizeOf<T0>()), out pointer.GetPinnableReference());
        }

        public unsafe void VertexArrayRange<T0>([Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            VertexArrayRange((uint) ((pointer.Length) * Unsafe.SizeOf<T0>()), out pointer.GetPinnableReference());
        }

        public unsafe T0 FlushVertexArrayRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            FlushVertexArrayRange(length, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 VertexArrayRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            VertexArrayRange(length, out T0 silkRet);
            return silkRet;
        }

        public AppleVertexArrayRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

