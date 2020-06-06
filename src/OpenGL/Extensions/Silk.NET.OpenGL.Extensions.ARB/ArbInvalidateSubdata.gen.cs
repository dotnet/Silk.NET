// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_invalidate_subdata")]
    public unsafe partial class ArbInvalidateSubdata : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_invalidate_subdata";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateBufferData([Flow(FlowDirection.In)] uint buffer)
            => ImplInvalidateBufferData(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplInvalidateBufferSubData(buffer, offset, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ARB* attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<ARB> attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ARB* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateSubFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateTexImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplInvalidateTexImage(texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateTexSubImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            InvalidateBufferSubData(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public ArbInvalidateSubdata(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

