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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_map_buffer_range")]
    public unsafe partial class ArbMapBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_map_buffer_range";
        [NativeApi(EntryPoint = "glFlushMappedBufferRange", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glMapBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] MapBufferAccessMask access);

        [NativeApi(EntryPoint = "glMapBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] MapBufferAccessMask access);

        public ArbMapBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

