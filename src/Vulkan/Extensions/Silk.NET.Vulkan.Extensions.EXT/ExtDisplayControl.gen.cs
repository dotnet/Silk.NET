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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_display_control")]
    public unsafe partial class ExtDisplayControl : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_display_control";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayPowerInfoEXT* pDisplayPowerInfo)
            => ImplDisplayPowerControl(device, display, pDisplayPowerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayPowerInfoEXT pDisplayPowerInfo)
            => ImplDisplayPowerControl(device, display, pDisplayPowerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCounterValue)
            => ImplGetSwapchainCounter(device, swapchain, counter, pCounterValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCounterValue)
            => ImplGetSwapchainCounter(device, swapchain, counter, pCounterValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence)
            => ImplRegisterDeviceEvent(device, pDeviceEventInfo, pAllocator, pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence)
            => ImplRegisterDeviceEvent(device, pDeviceEventInfo, pAllocator, pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence)
            => ImplRegisterDisplayEvent(device, display, pDisplayEventInfo, pAllocator, pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence)
            => ImplRegisterDisplayEvent(device, display, pDisplayEventInfo, pAllocator, pFence);

        public ExtDisplayControl(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

