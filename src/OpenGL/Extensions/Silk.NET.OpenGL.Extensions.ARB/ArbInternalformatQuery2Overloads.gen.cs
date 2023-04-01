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
    public static class ArbInternalformatQuery2Overloads
    {
        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformat(this ArbInternalformatQuery2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformat(target, internalformat, pname, count, out @params.GetPinnableReference());
        }

    }
}

