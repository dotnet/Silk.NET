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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbUniformBufferObjectOverloads
    {
        public static unsafe void GetActiveUniformBlock(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlock(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), uniformBlockName);
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformBlockName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length.GetPinnableReference(), out uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, length, out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, length, out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), uniformName);
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniformName(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformName)
        {
            // SpanOverloader
            thisApi.GetActiveUniformName(program, uniformIndex, bufSize, out length.GetPinnableReference(), out uniformName.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, uniformIndices, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetActiveUniforms(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveUniforms(program, uniformCount, in uniformIndices.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe uint GetUniformBlockIndex(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> uniformBlockName)
        {
            // SpanOverloader
            return thisApi.GetUniformBlockIndex(program, in uniformBlockName.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices.GetPinnableReference());
        }

        public static unsafe void GetUniformIndices(this ArbUniformBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uniformIndices)
        {
            // SpanOverloader
            thisApi.GetUniformIndices(program, uniformCount, in uniformNames, out uniformIndices.GetPinnableReference());
        }

    }
}

