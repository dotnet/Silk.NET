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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_copy_buffer")]
    public unsafe partial class ArbCopyBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_copy_buffer";
        [NativeApi(EntryPoint = "glCopyBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB readTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB writeTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB readTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB writeTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        public ArbCopyBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

