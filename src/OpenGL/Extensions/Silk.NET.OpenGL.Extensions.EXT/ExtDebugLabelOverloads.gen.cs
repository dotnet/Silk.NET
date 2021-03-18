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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    public static class ExtDebugLabelOverloads
    {
        public static unsafe void GetObjectLabel(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(type, @object, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(type, @object, bufSize, length, out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(type, @object, bufSize, out length.GetPinnableReference(), label);
        }

        public static unsafe void GetObjectLabel(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(type, @object, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void GetObjectLabel(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> label)
        {
            // SpanOverloader
            thisApi.GetObjectLabel(type, @object, bufSize, out length.GetPinnableReference(), out label.GetPinnableReference());
        }

        public static unsafe void LabelObject(this ExtDebugLabel thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.LabelObject(type, @object, length, in label.GetPinnableReference());
        }

    }
}

