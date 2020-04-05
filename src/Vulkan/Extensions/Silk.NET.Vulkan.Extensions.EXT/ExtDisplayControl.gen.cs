// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_display_control")]
    public abstract unsafe partial class ExtDisplayControl : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT")]
        public abstract unsafe Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayPowerInfoEXT* pDisplayPowerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT")]
        public abstract Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayPowerInfoEXT pDisplayPowerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT")]
        public abstract unsafe Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCounterValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT")]
        public abstract Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCounterValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT")]
        public abstract unsafe Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT")]
        public abstract Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT")]
        public abstract unsafe Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT")]
        public abstract Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        public ExtDisplayControl(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

