// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    public static class NvxProgressFenceOverloads
    {
        public static unsafe void ClientWaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.ClientWaitSemaphore(fenceObjectCount, semaphoreArray, in fenceValueArray.GetPinnableReference());
        }

        public static unsafe void ClientWaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray)
        {
            // SpanOverloader
            thisApi.ClientWaitSemaphore(fenceObjectCount, in semaphoreArray.GetPinnableReference(), fenceValueArray);
        }

        public static unsafe void ClientWaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.ClientWaitSemaphore(fenceObjectCount, in semaphoreArray.GetPinnableReference(), in fenceValueArray.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(signalGpu, fenceObjectCount, semaphoreArray, in fenceValueArray.GetPinnableReference());
        }

        public static unsafe void SignalSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(signalGpu, fenceObjectCount, in semaphoreArray.GetPinnableReference(), fenceValueArray);
        }

        public static unsafe void SignalSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.SignalSemaphore(signalGpu, fenceObjectCount, in semaphoreArray.GetPinnableReference(), in fenceValueArray.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint waitGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(waitGpu, fenceObjectCount, semaphoreArray, in fenceValueArray.GetPinnableReference());
        }

        public static unsafe void WaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint waitGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ulong* fenceValueArray)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(waitGpu, fenceObjectCount, in semaphoreArray.GetPinnableReference(), fenceValueArray);
        }

        public static unsafe void WaitSemaphore(this NvxProgressFence thisApi, [Flow(FlowDirection.In)] uint waitGpu, [Flow(FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> fenceValueArray)
        {
            // SpanOverloader
            thisApi.WaitSemaphore(waitGpu, fenceObjectCount, in semaphoreArray.GetPinnableReference(), in fenceValueArray.GetPinnableReference());
        }

    }
}

