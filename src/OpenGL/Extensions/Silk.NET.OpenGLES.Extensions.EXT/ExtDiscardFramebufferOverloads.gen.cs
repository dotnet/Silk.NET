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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtDiscardFramebufferOverloads
    {
        public static unsafe void DiscardFramebuffer(this ExtDiscardFramebuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> attachments)
        {
            // SpanOverloader
            thisApi.DiscardFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void DiscardFramebuffer(this ExtDiscardFramebuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.DiscardFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void DiscardFramebuffer(this ExtDiscardFramebuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> attachments)
        {
            // SpanOverloader
            thisApi.DiscardFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void DiscardFramebuffer(this ExtDiscardFramebuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.DiscardFramebuffer(target, numAttachments, in attachments.GetPinnableReference());
        }

    }
}

