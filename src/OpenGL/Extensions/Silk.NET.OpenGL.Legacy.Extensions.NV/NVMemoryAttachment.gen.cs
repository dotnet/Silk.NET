// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_memory_attachment")]
    public abstract unsafe partial class NVMemoryAttachment : NativeExtension<GL>
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
        public abstract void BufferAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

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
        public abstract unsafe void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* @params);

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
        public abstract void GetMemoryObjectDetachedResources([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> @params);

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
        public abstract void NamedBufferAttachMemory([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

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
        public abstract void ResetMemoryObjectParameter([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] NV pname);

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
        public abstract void TexAttachMemory([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

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
        public abstract void TextureAttachMemory([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

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
        public abstract void BufferAttachMemory([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

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
        public abstract void TexAttachMemory([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        public NVMemoryAttachment(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

