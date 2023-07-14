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
    [Extension("ARB_sparse_buffer")]
    public unsafe partial class ArbSparseBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sparse_buffer";
        [NativeApi(EntryPoint = "glBufferPageCommitmentARB", Convention = CallingConvention.Winapi)]
        public partial void BufferPageCommitment([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glNamedBufferPageCommitmentEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferPageCommitment([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        public ArbSparseBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

