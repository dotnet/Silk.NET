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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVTransformFeedbackOverloads
    {
        public static unsafe void ActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.ActiveVarying(program, in name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> location)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, out location.GetPinnableReference());
        }

        public static unsafe int GetVaryingLocation(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetVaryingLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void TransformFeedbackAttrib(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> attribs, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackAttrib(count, in attribs.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackStreamAttrib(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] ReadOnlySpan<int> bufstreams, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackStreamAttrib(count, attribs, nbuffers, in bufstreams.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackStreamAttrib(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] int* bufstreams, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackStreamAttrib(count, in attribs.GetPinnableReference(), nbuffers, bufstreams, bufferMode);
        }

        public static unsafe void TransformFeedbackStreamAttrib(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> attribs, [Flow(FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(FlowDirection.In)] ReadOnlySpan<int> bufstreams, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackStreamAttrib(count, in attribs.GetPinnableReference(), nbuffers, in bufstreams.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackVaryings(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> locations, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackVaryings(program, count, in locations.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackVaryings(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> locations, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackVaryings(program, count, in locations.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackVaryings(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<TransformFeedbackTokenNV> locations, [Flow(FlowDirection.In)] NV bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackVaryings(program, count, in locations.GetPinnableReference(), bufferMode);
        }

        public static unsafe void TransformFeedbackVaryings(this NVTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<TransformFeedbackTokenNV> locations, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // SpanOverloader
            thisApi.TransformFeedbackVaryings(program, count, in locations.GetPinnableReference(), bufferMode);
        }

    }
}

