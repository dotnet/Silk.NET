// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_memory_attachment")]
    public unsafe partial class NVMemoryAttachment : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_memory_attachment";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplBufferAttachMemory(target, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* @params)
            => ImplGetMemoryObjectDetachedResources(memory, pname, first, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetMemoryObjectDetachedResources(memory, pname, first, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferAttachMemory([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplNamedBufferAttachMemory(buffer, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetMemoryObjectParameterNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetMemoryObjectParameter([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname)
            => ImplResetMemoryObjectParameter(memory, pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexAttachMemory(target, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureAttachMemory([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTextureAttachMemory(texture, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferAttachMemory([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplBufferAttachMemory(target, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexAttachMemoryNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexAttachMemory([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexAttachMemory(target, memory, offset);

        public NVMemoryAttachment(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

