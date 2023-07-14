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

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    public static class MesaFramebufferFlipYOverloads
    {
        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this MesaFramebufferFlipY thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

