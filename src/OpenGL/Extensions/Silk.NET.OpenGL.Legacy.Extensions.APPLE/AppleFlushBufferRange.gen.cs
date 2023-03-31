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
    [Extension("APPLE_flush_buffer_range")]
    public unsafe partial class AppleFlushBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_flush_buffer_range";
        [NativeApi(EntryPoint = "glBufferParameteriAPPLE", Convention = CallingConvention.Winapi)]
        public partial void BufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        public AppleFlushBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

