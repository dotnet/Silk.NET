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
    public static class AtiVertexArrayObjectOverloads
    {
        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe uint NewObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI usage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NewObjectBuffer(size, in pointer.GetPinnableReference(), usage);
        }

        public static unsafe uint NewObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NewObjectBuffer(size, in pointer.GetPinnableReference(), usage);
        }

        public static unsafe void UpdateObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI preserve) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateObjectBuffer(buffer, offset, size, in pointer.GetPinnableReference(), preserve);
        }

        public static unsafe void UpdateObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateObjectBuffer(buffer, offset, size, in pointer.GetPinnableReference(), preserve);
        }

    }
}

