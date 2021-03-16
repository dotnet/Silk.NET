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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbInvalidateSubdataOverloads
    {
        public static unsafe void InvalidateFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateSubFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateSubFramebuffer(this ArbInvalidateSubdata thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateSubFramebuffer(target, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

    }
}

