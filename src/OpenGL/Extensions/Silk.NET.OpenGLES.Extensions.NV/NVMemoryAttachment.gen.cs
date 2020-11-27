// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_memory_attachment")]
    public unsafe partial class NVMemoryAttachment : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_attachment";
        [NativeApi(EntryPoint = "glBufferAttachMemoryNV")]
        public partial void BufferAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glBufferAttachMemoryNV")]
        public partial void BufferAttachMemory([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV")]
        public unsafe partial void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV")]
        public partial void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glNamedBufferAttachMemoryNV")]
        public partial void NamedBufferAttachMemory([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glResetMemoryObjectParameterNV")]
        public partial void ResetMemoryObjectParameter([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV")]
        public partial void TexAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexAttachMemoryNV")]
        public partial void TexAttachMemory([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureAttachMemoryNV")]
        public partial void TextureAttachMemory([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        public NVMemoryAttachment(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

