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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtMemoryObjectOverloads
    {
        public static unsafe void CreateMemoryObjects(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] Span<uint> memoryObjects)
        {
            // SpanOverloader
            thisApi.CreateMemoryObjects(n, out memoryObjects.GetPinnableReference());
        }

        public static unsafe void DeleteMemoryObjects(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> memoryObjects)
        {
            // SpanOverloader
            thisApi.DeleteMemoryObjects(n, in memoryObjects.GetPinnableReference());
        }

        public static unsafe void GetMemoryObjectParameter(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMemoryObjectParameter(memoryObject, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMemoryObjectParameter(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMemoryObjectParameter(memoryObject, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetUnsignedByte(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<byte> data)
        {
            // SpanOverloader
            thisApi.GetUnsignedByte(target, index, out data.GetPinnableReference());
        }

        public static unsafe void MemoryObjectParameter(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MemoryObjectParameter(memoryObject, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MemoryObjectParameter(this ExtMemoryObject thisApi, [Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MemoryObjectParameter(memoryObject, pname, in @params.GetPinnableReference());
        }

    }
}

