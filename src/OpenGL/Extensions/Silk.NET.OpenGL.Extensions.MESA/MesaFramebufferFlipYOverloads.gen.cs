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

namespace Silk.NET.OpenGL.Extensions.MESA
{
    public static class MesaFramebufferFlipYOverloads
    {
        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(FlowDirection.In)] MESA target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

