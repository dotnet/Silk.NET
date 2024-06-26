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
    [Extension("ARB_invalidate_subdata")]
    public unsafe partial class ArbInvalidateSubdata : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_invalidate_subdata";
        [NativeApi(EntryPoint = "glInvalidateBufferData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glInvalidateBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InvalidateFramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InvalidateFramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InvalidateFramebufferAttachment attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InvalidateFramebufferAttachment attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateTexImage", Convention = CallingConvention.Winapi)]
        public partial void InvalidateTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glInvalidateTexSubImage", Convention = CallingConvention.Winapi)]
        public partial void InvalidateTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        public unsafe void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateSubFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public unsafe void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateSubFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public unsafe void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateSubFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public unsafe void InvalidateSubFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateSubFramebuffer(target, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public ArbInvalidateSubdata(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

