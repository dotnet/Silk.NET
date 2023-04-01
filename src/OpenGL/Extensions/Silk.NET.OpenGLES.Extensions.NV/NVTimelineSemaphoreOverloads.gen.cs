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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVTimelineSemaphoreOverloads
    {
        public static unsafe void CreateSemaphores(this NVTimelineSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> semaphores)
        {
            // SpanOverloader
            thisApi.CreateSemaphores(n, out semaphores.GetPinnableReference());
        }

        public static unsafe void GetSemaphoreParameter(this NVTimelineSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSemaphoreParameter(semaphore, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSemaphoreParameter(this NVTimelineSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSemaphoreParameter(semaphore, pname, out @params.GetPinnableReference());
        }

        public static unsafe void SemaphoreParameter(this NVTimelineSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.SemaphoreParameter(semaphore, pname, in @params.GetPinnableReference());
        }

        public static unsafe void SemaphoreParameter(this NVTimelineSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.SemaphoreParameter(semaphore, pname, in @params.GetPinnableReference());
        }

    }
}

