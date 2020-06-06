// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_timeline_semaphore")]
    public unsafe partial class KhrTimelineSemaphore : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_timeline_semaphore";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue)
            => ImplGetSemaphoreCounterValue(device, semaphore, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue)
            => ImplGetSemaphoreCounterValue(device, semaphore, pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo)
            => ImplSignalSemaphore(device, pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreSignalInfo pSignalInfo)
            => ImplSignalSemaphore(device, pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout)
            => ImplWaitSemaphores(device, pWaitInfo, timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout)
            => ImplWaitSemaphores(device, pWaitInfo, timeout);

        public KhrTimelineSemaphore(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

