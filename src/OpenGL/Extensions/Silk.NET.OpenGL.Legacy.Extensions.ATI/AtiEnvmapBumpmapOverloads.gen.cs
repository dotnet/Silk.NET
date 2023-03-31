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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiEnvmapBumpmapOverloads
    {
        public static unsafe void GetTexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTexBumpParameter(pname, out param.GetPinnableReference());
        }

        public static unsafe void GetTexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTexBumpParameter(pname, out param.GetPinnableReference());
        }

        public static unsafe void GetTexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> param)
        {
            // SpanOverloader
            thisApi.GetTexBumpParameter(pname, out param.GetPinnableReference());
        }

        public static unsafe void GetTexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> param)
        {
            // SpanOverloader
            thisApi.GetTexBumpParameter(pname, out param.GetPinnableReference());
        }

        public static unsafe void TexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.TexBumpParameter(pname, in param.GetPinnableReference());
        }

        public static unsafe void TexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.TexBumpParameter(pname, in param.GetPinnableReference());
        }

        public static unsafe void TexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.TexBumpParameter(pname, in param.GetPinnableReference());
        }

        public static unsafe void TexBumpParameter(this AtiEnvmapBumpmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.TexBumpParameter(pname, in param.GetPinnableReference());
        }

    }
}

