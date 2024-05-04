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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_display_control")]
    public unsafe partial class ExtDisplayControl : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_display_control";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayPowerInfoEXT* pDisplayPowerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDisplayPowerControlEXT", Convention = CallingConvention.Winapi)]
        public partial Result DisplayPowerControl([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayPowerInfoEXT pDisplayPowerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pCounterValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainCounterEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainCounter([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] SurfaceCounterFlagsEXT counter, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pCounterValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceEventInfoEXT* pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDeviceEventEXT", Convention = CallingConvention.Winapi)]
        public partial Result RegisterDeviceEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceEventInfoEXT pDeviceEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayEventInfoEXT* pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0)] ref Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkRegisterDisplayEventEXT", Convention = CallingConvention.Winapi)]
        public partial Result RegisterDisplayEvent([Count(Count = 0)] Device device, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DisplayEventInfoEXT pDisplayEventInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0)] ref Fence pFence);

        public ExtDisplayControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

