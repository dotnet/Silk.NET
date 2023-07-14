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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrTimelineSemaphoreOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreCounterValue(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pValue)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreCounterValue(device, semaphore, out pValue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SignalSemaphore(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreSignalInfo> pSignalInfo)
        {
            // SpanOverloader
            return thisApi.SignalSemaphore(device, in pSignalInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitSemaphores(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreWaitInfo> pWaitInfo, [Count(Count = 0)] ulong timeout)
        {
            // SpanOverloader
            return thisApi.WaitSemaphores(device, in pWaitInfo.GetPinnableReference(), timeout);
        }

    }
}

