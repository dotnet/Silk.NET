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
    [Extension("NV_memory_attachment")]
    public unsafe partial class NVMemoryAttachment : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_attachment";
        [NativeApi(EntryPoint = "glBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectDetachedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectDetachedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glNamedBufferAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glResetMemoryObjectParameterNV", Convention = CallingConvention.Winapi)]
        public partial void ResetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TexAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TexAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureAttachMemoryNV", Convention = CallingConvention.Winapi)]
        public partial void TextureAttachMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        public unsafe uint GetMemoryObjectDetachedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetMemoryObjectDetachedResources(memory, pname, first, count, out uint silkRet);
            return silkRet;
        }

        public NVMemoryAttachment(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

