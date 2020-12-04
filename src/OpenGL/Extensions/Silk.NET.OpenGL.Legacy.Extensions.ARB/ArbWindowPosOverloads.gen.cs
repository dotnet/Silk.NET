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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbWindowPosOverloads
    {
        public static unsafe void WindowPos2(this ArbWindowPos thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.WindowPos2(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos2(this ArbWindowPos thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.WindowPos2(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos2(this ArbWindowPos thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.WindowPos2(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos2(this ArbWindowPos thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.WindowPos2(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos3(this ArbWindowPos thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.WindowPos3(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos3(this ArbWindowPos thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.WindowPos3(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos3(this ArbWindowPos thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.WindowPos3(in v.GetPinnableReference());
        }

        public static unsafe void WindowPos3(this ArbWindowPos thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.WindowPos3(in v.GetPinnableReference());
        }

    }
}

