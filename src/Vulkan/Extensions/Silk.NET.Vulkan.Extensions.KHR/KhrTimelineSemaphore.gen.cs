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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_timeline_semaphore")]
    public unsafe partial class KhrTimelineSemaphore : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_timeline_semaphore";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreSignalInfo pSignalInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout);

        public KhrTimelineSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

