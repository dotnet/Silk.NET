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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtCullVertexOverloads
    {
        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

    }
}

