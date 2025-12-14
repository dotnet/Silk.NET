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

namespace Silk.NET.Vulkan.Extensions.OHOS
{
    public static class OhosNativeBufferOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSwapchainGrallocUsageOhos(this OhosNativeBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageUsageFlags imageUsage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> grallocUsage)
        {
            // SpanOverloader
            return thisApi.GetSwapchainGrallocUsageOhos(device, format, imageUsage, out grallocUsage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSignalReleaseImageOhos(this OhosNativeBuffer thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Semaphore* pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] Span<int> pNativeFenceFd)
        {
            // SpanOverloader
            return thisApi.QueueSignalReleaseImageOhos(queue, waitSemaphoreCount, pWaitSemaphores, image, ref pNativeFenceFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSignalReleaseImageOhos(this OhosNativeBuffer thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Semaphore> pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] int* pNativeFenceFd)
        {
            // SpanOverloader
            return thisApi.QueueSignalReleaseImageOhos(queue, waitSemaphoreCount, in pWaitSemaphores.GetPinnableReference(), image, pNativeFenceFd);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueueSignalReleaseImageOhos(this OhosNativeBuffer thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Semaphore> pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] Span<int> pNativeFenceFd)
        {
            // SpanOverloader
            return thisApi.QueueSignalReleaseImageOhos(queue, waitSemaphoreCount, in pWaitSemaphores.GetPinnableReference(), image, ref pNativeFenceFd.GetPinnableReference());
        }

    }
}

