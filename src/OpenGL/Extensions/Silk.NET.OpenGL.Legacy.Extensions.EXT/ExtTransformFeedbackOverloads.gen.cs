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
    public static class ExtTransformFeedbackOverloads
    {
        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

    }
}

