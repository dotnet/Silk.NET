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
    public static class ArbBufferStorageOverloads
    {
        public static unsafe void BufferStorage<T0>(this ArbBufferStorage thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferStorage(target, size, dataSpp, flags);
        }

        public static unsafe void BufferStorage<T0>(this ArbBufferStorage thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferStorage(target, size, dataSpp, flags);
        }

        public static unsafe void BufferStorage<T0>(this ArbBufferStorage thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferStorage(target, size, dataSpp, flags);
        }

    }
}

