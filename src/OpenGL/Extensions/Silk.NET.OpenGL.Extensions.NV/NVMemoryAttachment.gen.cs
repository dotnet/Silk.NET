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
    [Extension("NV_memory_attachment")]
    public unsafe partial class NVMemoryAttachment : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_attachment";
        [NativeApi(EntryPoint = "glBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAttachMemory([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glNamedBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferAttachMemory([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glResetMemoryObjectParameterNV", Convention = CallingConvention.Winapi)]
        public partial void ResetMemoryObjectParameter([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TexAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TexAttachMemory([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TextureAttachMemory([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        public NVMemoryAttachment(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

