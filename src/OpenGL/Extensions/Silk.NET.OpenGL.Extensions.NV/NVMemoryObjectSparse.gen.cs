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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_memory_object_sparse")]
    public unsafe partial class NVMemoryObjectSparse : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_object_sparse";
        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void BufferPageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong memOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glBufferPageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void BufferPageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong memOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glNamedBufferPageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferPageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong memOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void TexPageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexPageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void TexPageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexturePageCommitmentMemNV", Convention = CallingConvention.Winapi)]
        public partial void TexturePageCommitmentMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        public NVMemoryObjectSparse(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

