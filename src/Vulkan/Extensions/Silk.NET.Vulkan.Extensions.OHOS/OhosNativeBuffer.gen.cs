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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.OHOS
{
    [Extension("VK_OHOS_native_buffer")]
    public unsafe partial class OhosNativeBuffer : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_OHOS_native_buffer";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireImageOHOS", Convention = CallingConvention.Winapi)]
        public partial Result AcquireImageOhos([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] int nativeFenceFd, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainGrallocUsageOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainGrallocUsageOhos([Count(Count = 0)] Device device, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageUsageFlags imageUsage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* grallocUsage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainGrallocUsageOHOS", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainGrallocUsageOhos([Count(Count = 0)] Device device, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageUsageFlags imageUsage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong grallocUsage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSignalReleaseImageOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Semaphore* pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] int* pNativeFenceFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSignalReleaseImageOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Semaphore* pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] ref int pNativeFenceFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSignalReleaseImageOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Semaphore pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] int* pNativeFenceFd);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSignalReleaseImageOHOS", Convention = CallingConvention.Winapi)]
        public partial Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Semaphore pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] ref int pNativeFenceFd);

        /// <summary>To be documented.</summary>
        public unsafe Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Semaphore> pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] int* pNativeFenceFd)
        {
            // ImplicitCountSpanOverloader
            return QueueSignalReleaseImageOhos(queue, (uint) pWaitSemaphores.Length, in pWaitSemaphores.GetPinnableReference(), image, pNativeFenceFd);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueueSignalReleaseImageOhos([Count(Count = 0)] Queue queue, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Semaphore> pWaitSemaphores, [Count(Count = 0)] Image image, [Count(Count = 0)] ref int pNativeFenceFd)
        {
            // ImplicitCountSpanOverloader
            return QueueSignalReleaseImageOhos(queue, (uint) pWaitSemaphores.Length, in pWaitSemaphores.GetPinnableReference(), image, ref pNativeFenceFd);
        }

        public OhosNativeBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

