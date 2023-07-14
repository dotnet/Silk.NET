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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbTransformFeedback2Overloads
    {
        public static unsafe void DeleteTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

    }
}

