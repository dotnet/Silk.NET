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
    public static class ExtSemaphoreWin32Overloads
    {
        public static unsafe void ImportSemaphoreWin32Handle<T0>(this ExtSemaphoreWin32 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT handleType, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportSemaphoreWin32Handle(semaphore, handleType, out handle.GetPinnableReference());
        }

        public static unsafe void ImportSemaphoreWin32Handle<T0>(this ExtSemaphoreWin32 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalHandleType handleType, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportSemaphoreWin32Handle(semaphore, handleType, out handle.GetPinnableReference());
        }

        public static unsafe void ImportSemaphoreWin32Name<T0>(this ExtSemaphoreWin32 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT handleType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportSemaphoreWin32Name(semaphore, handleType, in name.GetPinnableReference());
        }

        public static unsafe void ImportSemaphoreWin32Name<T0>(this ExtSemaphoreWin32 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalHandleType handleType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportSemaphoreWin32Name(semaphore, handleType, in name.GetPinnableReference());
        }

    }
}

