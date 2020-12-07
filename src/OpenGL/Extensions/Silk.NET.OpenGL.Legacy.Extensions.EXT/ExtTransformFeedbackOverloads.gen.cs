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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtTransformFeedbackOverloads
    {
        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<EXT> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbackVarying(this ExtTransformFeedback thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbackVarying(program, index, bufSize, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

    }
}

