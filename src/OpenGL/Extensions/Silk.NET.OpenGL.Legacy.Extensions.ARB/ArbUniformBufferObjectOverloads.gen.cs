// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbUniformBufferObjectOverloads
    {
        public static unsafe void GetActiveUniformBlock(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlock(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), uniformBlockName);
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, length, out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, length, out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), uniformName);
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe uint GetUniformBlockIndex(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<byte> uniformBlockName)
        {
            // SpanOverloader
            return thisApi.GetUniformBlockIndex(program, in uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this ArbUniformBufferObject thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, in uniformNames, out uniformIndices.GetPinnableReference());
        }

    }
}

