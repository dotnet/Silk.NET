// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbFramebufferObjectOverloads
    {
        public static unsafe void DeleteFramebuffers(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> framebuffers)
        {
            // SpanOverloader
            thisApi.DeleteFramebuffers(n, in framebuffers.GetPinnableReference());
        }

        public static unsafe void DeleteRenderbuffers(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> renderbuffers)
        {
            // SpanOverloader
            thisApi.DeleteRenderbuffers(n, in renderbuffers.GetPinnableReference());
        }

        public static unsafe void GenFramebuffers(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
        {
            // SpanOverloader
            thisApi.GenFramebuffers(n, out framebuffers.GetPinnableReference());
        }

        public static unsafe void GenRenderbuffers(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // SpanOverloader
            thisApi.GenRenderbuffers(n, out renderbuffers.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferAttachmentParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferAttachmentParameter(target, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetRenderbufferParameter(this ArbFramebufferObject thisApi, [Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetRenderbufferParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

